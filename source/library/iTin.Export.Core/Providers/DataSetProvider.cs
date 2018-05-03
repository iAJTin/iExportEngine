
namespace iTin.Export.Providers
{
    using System;
    using System.ComponentModel.Composition;
    using System.Data;
    using System.Diagnostics;
    using System.IO;

    using ComponentModel.Provider;
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.Provider.IProvider" />.
    /// Represents a source object based on the <see cref="T:System.Data.DataSet" />.
    /// </summary>
    [Export(typeof(IProvider))]
    [ProviderOptions(Name = "DataSetProvider", Author = "iTin", Company = "iTin", Version = 1, Description = "Allow export inputs of type DataSet")]
    public class DataSetProvider : BaseProvider
    {
        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DataSet _dataSet;
        #endregion

        #region constructor/s

        #region [public] DataSetProvider(ProviderParameters): Initializes a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Providers.DataSetProvider" /> class.
        /// </summary>
        /// <param name="constructorParams">The constructor parameters.</param>
        [ImportingConstructor]
        public DataSetProvider(ProviderParameters constructorParams)
            : this((DataSet)SentinelHelper.PassThroughNonNull(constructorParams).Data)
        {
        }
        #endregion

        #region [public] DataSetProvider(DataSet): Initializes a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Providers.DataSetProvider" /> class.
        /// </summary>
        /// <param name="dataSet">A <see cref="T:System.Data.DataSet" /> object than contains the information.</param>            
        public DataSetProvider(DataSet dataSet) 
        {
            _dataSet = dataSet;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (bool) CanCreateSourceXml: Gets a value indicating whether you can create an Xml file from the current instance of the object
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// Always returns <strong>true</strong>.
        /// </value>
        public override bool CanCreateInputXml => true;
        #endregion

        #region [public] {override} (bool) CanGetDataTable: Gets a value indicating whether this instance can get data table
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance can get data table.
        /// </summary>
        /// <value>
        /// Always returns <strong>true</strong>.
        /// </value>
        public override bool CanGetDataTable => true;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) OnCreateInputXml(): Concrete implementation by object type
        /// <inheritdoc />
        /// <summary>
        /// Concrete implementation by object type.
        /// </summary>
        protected override void OnCreateInputXml()
        {
            if (_dataSet == null)
            {
                return;
            }

            if (!_dataSet.GetType().Name.Equals("GenericDataLinkDataSet", StringComparison.OrdinalIgnoreCase))
            {
                using (var ds = _dataSet.Copy())
                {
                    var tables = ds.Tables;
                    foreach (DataTable table in tables)
                    {
                        var columns = table.Columns;
                        foreach (DataColumn column in columns)
                        {
                            column.ColumnName = column.ColumnName.ToUpperInvariant();
                            column.ColumnMapping = MappingType.Attribute;
                        }
                    }

                    using (var stream = new MemoryStream())
                    {
                        ds.WriteXml(stream);
                        stream.SaveToFile(InputUri.AbsolutePath);
                    }
                }
            }
            else
            {
                var tables = _dataSet.Tables;
                foreach (DataTable table in tables)
                {
                    var columns = table.Columns;
                    foreach (DataColumn column in columns)
                    {
                        column.ColumnMapping = MappingType.Attribute;
                    }
                }

                using (var stream = new MemoryStream())
                {
                    _dataSet.WriteXml(stream);
                    stream.SaveToFile(InputUri.AbsolutePath);
                }
            }
        }
        #endregion

        #region [public] {override} (DataTable) OnGetDataTable(): Gets a reference to the DataTable object that contains the data this instance
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Data.DataTable" /> object that contains the data this instance.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Data.DataTable" /> object.
        /// </returns>
        protected override DataTable OnGetDataTable()
        {
            if (_dataSet == null)
            {
                return null;
            }

            DataTable dt;
            if (!_dataSet.GetType().Name.Equals("GenericDataLinkDataSet", StringComparison.OrdinalIgnoreCase))
            {
                var ds = _dataSet.Copy();
                dt = ds.Tables[Input.Model.Table.Name];
            }
            else
            {
                dt = _dataSet.Tables[Input.Model.Table.Name];                
            }

            return dt;
        }
        #endregion

        #endregion
    }
}
