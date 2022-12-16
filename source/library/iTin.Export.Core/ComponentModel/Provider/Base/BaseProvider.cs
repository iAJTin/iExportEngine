﻿
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

namespace iTin.Export.ComponentModel.Provider
{
    using Helpers;
    using Input;
    using Model;
    using Writer;

    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.IProvider" />.
    /// Which acts as the base class for future providers.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different provider types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.ComponentModel.Provider.DataSetProvider" /></term>
    ///       <description>Represents a custom provider for <see cref="T:System.Data.DataSet" /> inputs. For more information please see <see cref="T:iTin.Export.ComponentModel.Provider.DataSetProvider" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.ComponentModel.Provider.XmlProvider" /></term>
    ///       <description>Represents a custom provider for <c>Xml</c> types. For more information please see <see cref="T:iTin.Export.ComponentModel.Provider.XmlProvider" /></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public abstract class BaseProvider : IProvider
    {
        #region private static readonly members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] EmptySpecialCharsArray = { };

        #endregion

        #region private readonly members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ProviderOptionsMetadata _optionsMetadataInformation;

        #endregion

        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Provider.BaseProvider"/> class.
        /// </summary>
        protected BaseProvider()
        {
            SpecialChars = EmptySpecialCharsArray;
            InputUri = FileHelper.GetUniqueTempRandomFile();
            _optionsMetadataInformation = new ProviderOptionsMetadata(this);
        }

        #endregion

        #region public properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the data model.
        /// </summary>
        /// <value>
        /// Reference to data model.
        /// </value>
        public InputDataModel Input { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference that contains the metadata information about this provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.AdapterMetadataInformation" /> that contains the extended information about this provider.
        /// </value>
        public ProviderOptionsMetadata ProviderMetadata => _optionsMetadataInformation;

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to input file.
        /// </summary>
        /// <value>
        /// Reference to the input file.
        /// </value>
        public Uri InputUri { get; protected set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets an special char array.
        /// </summary>
        /// <value>
        /// Special char array.
        /// </value>
        public IEnumerable<char> SpecialChars { get; protected set; }

        #endregion

        #region public virtual properties
        
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if you can create an <strong>XML</strong>; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool CanCreateInputXml => false;

        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance can get data table.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance can get data table; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool CanGetDataTable => false;

        #endregion

        #region protected static properties

        /// <summary>
        /// Gets the empty special chars.
        /// </summary>
        /// <returns>
        /// Empty special chars array.
        /// </returns>
        protected static IEnumerable<char> EmptySpecialChars => (char[])EmptySpecialCharsArray.Clone();

        #endregion

        #region public static methods

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
                parsedField =$"_x{asciicode.ToString("x4", CultureInfo.InvariantCulture).ToUpper(CultureInfo.InvariantCulture)}_{cleanedfield}";
            }

            return parsedField;
        }

        #endregion

        #region public methods

        /// <inheritdoc />
        /// <summary>
        /// Creates the <c>Xml</c> source file from.
        /// </summary>
        public void CreateInputXml()
        {
            if (CanCreateInputXml)
            {
                OnCreateInputXml();
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Add a data model to this provider.
        /// </summary>
        /// <param name="model">Data model.</param>
        public void SetInputDataModel(InputDataModel model)
        {
            Input = model;
        }

        /// <inheritdoc />
        /// <summary>
        /// Export specified input data model with this provider by applying the specified writer in configuration file.
        /// </summary>
        /// <param name="settings">Export settings</param>
        public void Export(ExportSettings settings)
        {
            SentinelHelper.ArgumentNull(settings);

            var root = Input.Model;
            var exporter = root.Table.Exporter;
            var exporterType = exporter.ExporterType;

            switch (exporterType)
            {
                #region Xslt
                case KnownExporter.Xslt:
                    var output = root.ResolveRelativePath(KnownRelativeFilePath.Output);
                    var transform = root.ResolveRelativePath(KnownRelativeFilePath.Transform);

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
                        writer.Provider = this;

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
        public string Parse(string value) => Parse(value, SpecialChars);

        /// <inheritdoc />
        /// <summary>
        /// Sets an special char array to this provider.
        /// </summary>
        /// <param name="value">Special chars array.</param>
        public void SetSpecialChars(IEnumerable<char> value)
        {
            SpecialChars = value;
        }

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

            return LoadXmlFromFile(InputUri.OriginalString, Input.Model.Table.Name);
        }

        #endregion

        #region public override methods

        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> than represents the current object.
        /// </returns>
        public override string ToString() => $"Type=\"{GetType().Name}\"";

        #endregion

        #region protected static methods

        /// <summary>
        /// Retrieves <c>Xml</c> content of specified <paramref name="table" /> in a file.
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
        
        #region protected virtual methods

        /// <summary>
        /// Concrete implementation by object type.
        /// </summary>
        protected virtual void OnCreateInputXml()
        {
        }

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
    }
}
