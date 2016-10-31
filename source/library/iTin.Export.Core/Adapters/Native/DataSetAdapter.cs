using System;
using System.ComponentModel.Composition;
using System.Data;
using System.Diagnostics;
using System.IO;

using iTin.Export.ComponentModel; 
using iTin.Export.Helper;

namespace iTin.Export.Adapters.Native
{
    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.IAdapter"/>.
    /// Represents a source object based on the <see cref="T:System.Data.DataSet" />.
    /// </summary>
    [Export(typeof(IAdapter))]
    [AdapterOptions(Name = "DataSetAdapter", Author = "iTin", Company = "iTin", Version = 1, Description = "Allow export inputs of type DataSet")]
    public class DataSetAdapter : BaseAdapter
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DataSet dataSet;
        #endregion

        #region Constructor/s

            #region [public] DataSetAdapter(TargetParameters): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Adapters.DataSetTarget" /> class.
            /// </summary>
            /// <param name="constructorParams">The constructor parameters.</param>
            [ImportingConstructor]
            public DataSetAdapter(AdapterParameters constructorParams)
                : this((DataSet)SentinelHelper.PassThroughNonNull(constructorParams).Data)
            {
            }
        #endregion

            #region [public] DataSetAdapter(DataSet): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Adapters.DataSetTarget" /> class.
            /// </summary>
            /// <param name="dataSet">A <see cref="T:System.Data.DataSet" /> object than contains the information.</param>            
            public DataSetAdapter(DataSet dataSet) 
            {
                this.dataSet = dataSet;
            }
            #endregion

        #endregion

        #region Public Override Properties

            #region [public] {override} (bool) CanCreateSourceXml: Gets a value indicating whether you can create an XML file from the current instance of the object.
            /// <summary>
            /// Gets a value indicating whether you can create an <strong>XML</strong> file from the current instance of the object.
            /// </summary>
            /// <value>
            /// Always returns <strong>true</strong>.
            /// </value>
            public override bool CanCreateInputXml
            {
                get { return true; }
            }
            #endregion

            #region [public] {override} (bool) CanGetDataTable: Gets a value indicating whether this instance can get data table.
            /// <summary>
            /// Gets a value indicating whether this instance can get data table.
            /// </summary>
            /// <value>
            /// Always returns <strong>true</strong>.
            /// </value>
            public override bool CanGetDataTable
            {
                get { return true; }
            }
            #endregion

        #endregion

        #region Protected Override Methods

            #region [protected] {override} (void) OnCreateInputXml(): Concrete implementation by object type.
            /// <summary>
            /// Concrete implementation by object type.
            /// </summary>
            protected override void OnCreateInputXml()
            {
                if (dataSet != null)
                {
                    if (!dataSet.GetType().Name.Equals("GenericDataLinkDataSet", StringComparison.OrdinalIgnoreCase))
                    {
                        using (var ds = dataSet.Copy())
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
                        var tables = dataSet.Tables;
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
                            dataSet.WriteXml(stream);
                            stream.SaveToFile(InputUri.AbsolutePath);
                        }
                    }
                }                              
            }
            #endregion

            #region [public] {override} (DataTable) OnGetDataTable(): Gets a reference to the DataTable object that contains the data this instance.
            /// <summary>
            /// Gets a reference to the <see cref="T:System.Data.DataTable" /> object that contains the data this instance.
            /// </summary>
            /// <returns>
            /// Reference to the <see cref="T:System.Data.DataTable" /> object.
            /// </returns>
            protected override DataTable OnGetDataTable()
            {
                DataTable dt = null;

                if (dataSet != null)
                {
                    if (!dataSet.GetType().Name.Equals("GenericDataLinkDataSet", StringComparison.OrdinalIgnoreCase))
                    {
                        var ds = dataSet.Copy();
                        dt = ds.Tables[DataModel.Data.Table.Name];
                    }
                    else
                    {
                        dt = dataSet.Tables[DataModel.Data.Table.Name];                
                    }
                }

                return dt;
            }
            #endregion

        #endregion
    }
}
