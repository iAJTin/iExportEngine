
namespace iTin.Export.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    using Helpers;
    using Model;

    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.IAdapter" />.
    /// Which acts as the base class for future adapters.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different adapter types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Adapters.DataSetTarget" /></term>
    ///       <description>Represents a custom adapter for <see cref="T:System.Data.DataSet" /> inputs. For more information please see <see cref="T:iTin.Export.Adapters.DataSetTarget" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Adapters.XmlTarget" /></term>
    ///       <description>Represents a custom adapter for <c>Xml</c> types. For more information please see <see cref="T:iTin.Export.Adapters.XmlTarget" /></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public abstract class BaseAdapter : IAdapter
    {
        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] EmptySpecialCharsArray = { };

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly AdapterExtendedInformation extendedInformation;
        #endregion

        #region constructor/s

        #region [protected] BaseAdapter(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAdapter"/> class.
        /// </summary>
        protected BaseAdapter()
        {
            SpecialChars = EmptySpecialCharsArray;
            InputUri = FileHelper.GetUniqueTempRandomFile();
            extendedInformation = new AdapterExtendedInformation(this);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (TargetDataModel) DataModel: Gets a reference to the data model
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the data model.
        /// </summary>
        /// <value>
        /// Reference to data model.
        /// </value>
        public AdapterDataModel DataModel { get; private set; }
        #endregion

        #region [public] (TargetExtendedInformation) ExtendedInformation: Gets a reference that contains the extended information about this target
        /// <summary>
        /// Gets a reference that contains the extended information about this target.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.TargetExtendedInformation"/> that contains the extended information about this target.
        /// </value>
        public AdapterExtendedInformation ExtendedInformation => extendedInformation;
        #endregion

        #region [public] (Uri) InputUri: Gets a reference to input file
        /// <summary>
        /// Gets a reference to input file.
        /// </summary>
        /// <value>
        /// Reference to the input file.
        /// </value>
        public Uri InputUri { get; protected set; }
        #endregion

        #region [public] (IEnumerable<char>) SpecialChars: Gets an special char array
        /// <summary>
        /// Gets or sets an special char array.
        /// </summary>
        /// <value>
        /// Special char array.
        /// </value>
        public IEnumerable<char> SpecialChars { get; protected set; }
        #endregion

        #endregion

        #region public virtual properties
        
        #region [public] {virtual} (bool) CanCreateInputXml: Gets a value indicating whether you can create an XML file from the current instance of the object.
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>XML</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if you can create an <strong>XML</strong>; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool CanCreateInputXml => false;
        #endregion

        #region [public] {virtual} (bool) CanGetDataTable: Gets a value indicating whether this instance can get data table.
        /// <summary>
        /// Gets a value indicating whether this instance can get data table.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance can get data table; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool CanGetDataTable => false;
        #endregion

        #endregion

        #region protected static properties

        #region [protected] {static} (IEnumerable<char>) EmptySpecialChars(): Gets the empty special chars.
        /// <summary>
        /// Gets the empty special chars.
        /// </summary>
        /// <returns>
        /// Empty special chars array.
        /// </returns>
        protected static IEnumerable<char> EmptySpecialChars => (char[])EmptySpecialCharsArray.Clone();
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (string) Parse(string, IEnumerable<char>): Parse an string and replace the special chars defined in specialChars by a hexadecimal pattern
        /// <summary>
        /// Parse an <see cref="T:System.String" /> and replace the special chars defined in <paramref name="specialChars"/> by a hexadecimal pattern.
        /// </summary>
        /// <param name="value"><see cref="T:System.String" /> to parse</param>
        /// <param name="specialChars">Special chars to replace</param>
        /// <returns>
        /// The parsed string.
        /// </returns>
        /// <remarks>
        /// Analyzes the argument <paramref name="value"/>, replacing <paramref name="specialChars"/> by the pattern '_x####_', where:
        /// ####: Represents ASCII char code in Hexadecimal format
        /// If the argument <paramref name="value"/> does not contain any special characters returns the argument unchanged.
        /// </remarks>
        public static string Parse(string value, IEnumerable<char> specialChars)
        {
            SentinelHelper.ArgumentNull(value);

            if (specialChars == null)
            {
                return value;
            }

            var parsedField = value;
            var chars = specialChars.ToList();
            foreach (var specialchar in chars)
            {
                if (!value.StartsWith(specialchar.ToString(CultureInfo.InvariantCulture), StringComparison.Ordinal))
                {
                    continue;
                }

                var charAsString = specialchar.ToString(CultureInfo.InvariantCulture);
                var asciicode = Encoding.ASCII.GetBytes(charAsString)[0];
                var cleanedfield = value.Replace(charAsString, string.Empty);
                parsedField = string.Format(CultureInfo.InvariantCulture, "_x{0}_{1}", asciicode.ToString("x4", CultureInfo.InvariantCulture).ToUpper(CultureInfo.InvariantCulture), cleanedfield);
            }

            return parsedField;
        }
        #endregion

        #endregion

        #region Public Methods

        #region [public] (void) CreateInputXml(): Creates the XML source file
        /// <inheritdoc />
        /// <summary>
        /// Creates the XML source file from.
        /// </summary>
        public void CreateInputXml()
        {
            if (CanCreateInputXml)
            {
                OnCreateInputXml();
            }
        }
        #endregion

        #region [public] (void) SetDataModel(TargetDataModel): Add a data model to this target
        /// <inheritdoc />
        /// <summary>
        /// Add a data model to this target.
        /// </summary>
        /// <param name="model">Data model.</param>
        public void SetDataModel(AdapterDataModel model)
        {
            DataModel = model;
        }
        #endregion

        #region [public] (void) Export(ExportSettings): Export this target by applying the specified configuration
        /// <inheritdoc />
        /// <summary>
        /// Export this target by applying the specified configuration.
        /// </summary>
        /// <param name="settings">Export settings</param>
        public void Export(ExportSettings settings)
        {
            SentinelHelper.ArgumentNull(settings);

            var root = DataModel.Data;
            var exporter = root.Table.Exporter;
            var exporterType = exporter.ExporterType;

            switch (exporterType)
            {
                #region Xslt
                case KnownExporter.Xslt:
                    var output = root.ParseRelativeFilePath(KnownRelativeFilePath.Output);
                    var transform = root.ParseRelativeFilePath(KnownRelativeFilePath.Transform);

                    settings.OutputFile = new Uri(output);
                    settings.TransformFile = new Uri(transform);
                    InputUri.Transform(settings);
                    break;
                #endregion

                #region Template, Writer
                case KnownExporter.Writer:
                case KnownExporter.Template:
                    WriterModel writermodel;
                    if (exporterType == KnownExporter.Template)
                    {
                        var template = (TemplateModel)exporter.Current;
                        writermodel = template.Writer;
                    }
                    else
                    {
                        writermodel = (WriterModel)exporter.Current;
                    }

                    var writers = WritersCache.Instance(WritersCache.CreateWriterSettingsFromModel(writermodel));
                    using (var writer = writers.GetWriter(writermodel))
                    {
                        writer.Adapter = this;

                        switch (writer.WriterIdentifier)
                        {
                            case KnownWriterIdentifier.WriterStream:
                                ((IWriterStream)writer).CreateStream();
                                break;

                            case KnownWriterIdentifier.WriterXml:
                                ((IWriterXml)writer).CreateWriter();
                                break;
                        }

                        writer.Generate(settings);
                    }

                    break;
                #endregion
            }
        }
        #endregion

        #region [public] (string) Parse(string): Parse an String and replace the special chars defined in SpecialChars by a hexadecimal pattern
        /// <inheritdoc />
        /// <summary>
        /// Parse an <see cref="T:System.String" /> and replace the special chars defined in <see cref="P:iTin.Export.ComponentModel.BaseTarget.SpecialChars" /> by a hexadecimal pattern.
        /// </summary>
        /// <param name="value"><see cref="T:System.String" /> to parse</param>
        /// <returns>
        /// Parsed <see cref="T:System.String" />.
        /// </returns>
        /// <remarks>
        /// Analyzes the argument <paramref name="value" />, replacing <see cref="P:iTin.Export.ComponentModel.BaseTarget.SpecialChars" /> by the pattern '_x####_', where:
        /// ####: Represents ASCII char code in Hexadecimal format
        /// If the argument <paramref name="value" /> does not contain any <see cref="P:iTin.Export.ComponentModel.BaseTarget.SpecialChars" /> returns the argument unchanged.
        /// </remarks>        
        public string Parse(string value)
        {
            return Parse(value, SpecialChars);
        }
        #endregion

        #region [public] (void) SetSpecialChars(IEnumerable<char>): Sets an special char array to this target
        /// <inheritdoc />
        /// <summary>
        /// Sets an special char array to this target.
        /// </summary>
        /// <param name="value">Special chars array.</param>
        public void SetSpecialChars(IEnumerable<char> value)
        {
            SpecialChars = value;
        }
        #endregion

        #region [public] (DataTable) ToDataTable(): Gets a reference to the DataTable object that contains the data this instance
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Data.DataTable" /> object that contains the data this instance.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Data.DataTable" /> object.
        /// </returns>
        public DataTable ToDataTable()
        {
            if (CanGetDataTable)
            {
                return OnGetDataTable();
            }

            throw new InvalidOperationException();
        }
        #endregion

        #region [public] (IEnumerable<XElement>) ToXml(): Gets a reference to the enumerable list object that contains the data this instance
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Collections.Generic.IEnumerable`1" /> object that contains the data this instance.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Collections.Generic.IEnumerable`1" /> object.
        /// </returns>
        public IEnumerable<XElement> ToXml()
        {
            CreateInputXml();
            return LoadXmlFromFile(InputUri.OriginalString, DataModel.Data.Table.Name);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string than represents the current object
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> than represents the current object.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Type=\"{0}\"", GetType().Name);
        }
        #endregion

        #endregion

        #region protected static methods

        #region [protected] {static} (IEnumerable<XElement>) LoadXmlFromFile(string, string): Retrieves XML content of specified table in a file
        /// <summary>
        /// Retrieves <strong>XML</strong> content of specified <paramref name="table" /> in a file.
        /// </summary>
        /// <param name="fileName">Target filename</param>
        /// <param name="table">Table to retrieve</param>
        /// <returns>
        /// A collection of <see cref="T:System.Xml.Linq.XElement"/> that contains the table content as <strong>XML</strong>.
        /// </returns>
        protected static IEnumerable<XElement> LoadXmlFromFile(string fileName, string table)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(table));
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            IEnumerable<XElement> nodes = null;
            using (var stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                var reader = new XmlTextReader(stream);
                var document = XDocument.Load(reader);
                var root = document.Root;
                if (root != null)
                {
                    nodes = table == "*"
                        ? root.Elements()
                        : root.Elements(table);
                }

                ////var query = from element in root.Elements()
                ////            group element.Attributes().FirstOrDefault() by element.Name;
                ////var qq = from e in query let c = e.Count() where c > 1 select e.GetEnumerator();
                ////var vvvv = qq.Cast<XAttribute>().ToList();
            }

            return nodes;
        }
        #endregion
        
        #endregion
        
        #region protected virtual methods

        #region [protected] {virtual} (void) OnCreateInputXml(): Concrete implementation by object type
        /// <summary>
        /// Concrete implementation by object type.
        /// </summary>
        protected virtual void OnCreateInputXml()
        {
        }
        #endregion

        #region [protected] {virtual} (DataTable) OnGetDataTable(): Concrete implementation by object type
        /// <summary>
        /// Concrete implementation by object type.
        /// </summary>
        /// <returns>
        /// The data Table
        /// </returns>
        protected virtual DataTable OnGetDataTable()
        {
            return null;
        }
        #endregion

        #endregion
    }
}
