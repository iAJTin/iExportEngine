
namespace iTin.Export.ComponentModel
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Linq;

    using Model;
    using Provider;
    using Writer;

    /// <summary>
    /// 
    /// </summary>
    public class ModelService 
    {
        #region private static members
        // Static members are 'eagerly initialized', that is, immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization.
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ModelService Default = new ModelService();
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IWriter _writer;
        #endregion

        #region public static properties

        #region [public] {static} (ModelService) Instance: Returns a unique instance of the class
        /// <summary>
        /// Returns a unique instance of the class
        /// </summary>
        public static ModelService Instance => Default;
        #endregion

        #endregion

        #region public properties

        #region [public] (int) CurrentCol:
        /// <summary>
        /// 
        /// </summary>
        public int CurrentCol { get; private set; }
        #endregion

        #region [public] (BaseDataFieldModel) CurrentField:
        /// <summary>
        /// 
        /// </summary>
        public BaseDataFieldModel CurrentField { get; private set; }
        #endregion

        #region [public] (int) CurrentRow:
        /// <summary>
        /// 
        /// </summary>
        public int CurrentRow { get; private set; }

        #endregion

        #region [public] (ExportModel) CurrentModel:
        /// <summary>
        /// 
        /// </summary>
        public ExportModel CurrentModel => _writer.Provider.Input.Model;
        #endregion

        #region [public] (IProvider) Provider:
        /// <summary>
        /// 
        /// </summary>
        public IProvider Provider => _writer.Provider;
        #endregion

        #region [public] (ExportsModel) Root:
        /// <summary>
        /// 
        /// </summary>
        public ExportsModel Root => _writer.Provider.Input.GetRoot();
        #endregion

        #region [public] (XElement[]) RawData:
        /// <summary>
        /// 
        /// </summary>
        public XElement[] RawData { get; private set ;}
        #endregion

        #region [public] (XElement[]) RawData:

        /// <summary>
        /// 
        /// </summary>
        public XElement[] RawDataFiltered
        {
            get
            {
                var hasDataFilter = !string.IsNullOrEmpty(CurrentModel.Table.Filter);
                if (!hasDataFilter)
                {
                    return RawData;
                }

                DataFilterModel filter = Resources.Filters.GetBy(CurrentModel.Table.Filter);
                if (filter == null)
                {
                    return RawData;
                }

                if (filter.Active == YesNo.No)
                {
                    return RawData;
                }

                var expression = filter.BuildFilterExpression();
                var rows = RawData.ToList().FindAll(item => expression.IsSatisfiedBy(item));

                return (XElement[])rows.ToArray().Clone();
            }
        }
        #endregion


        #region [public] (ReferencesModel) References:
        /// <summary>
        /// 
        /// </summary>
        public ReferencesModel References => _writer.Provider.Input.References;
        #endregion

        #region [public] (GlobalResourcesModel) Resources:
        /// <summary>
        /// 
        /// </summary>
        public GlobalResourcesModel Resources => _writer.Provider.Input.Resources;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetCurrentCol(int): 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void SetCurrentCol(int col)
        {            
            CurrentCol = col;
        }
        #endregion

        #region [public] (void) SetCurrentField(BaseDataFieldModel): 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="field"></param>
        public void SetCurrentField(BaseDataFieldModel field)
        {
            CurrentField = field;
        }
        #endregion

        #region [public] (void) SetCurrentRow(int): 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        public void SetCurrentRow(int row)
        {
            CurrentRow = row;
        }
        #endregion

        #region [public] (bool) TryGetUnderlyingDataAsDataTable(out DataTable):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool TryGetUnderlyingDataAsDataTable(out DataTable data)
        {
            
            data = null;
            if (!_writer.Provider.CanGetDataTable)
            {
                return false;
            }

            data = _writer.Provider.ToDataTable();
            return true;
        }
        #endregion

        #region [public] (bool) TryGetUnderlyingDataAsXml(out IEnumerable<XElement>):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool TryGetUnderlyingDataAsXml(out IEnumerable<XElement> data)
        {
            data = null;
            //if (!_writer.Provider.CanCreateInputXml)
            //{
            //    return false;
            //}

            data = _writer.Provider.ToXml();
            return true;
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Model=\"{CurrentModel.Name}\", Writer=\"{_writer.WriterMetadata.Name}\", Provider=\"{Provider.ProviderMetadata.Name}\"";
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetWriter(IWriter):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        internal void SetWriter(IWriter writer)
        {
            _writer = writer;
            RawData = (XElement[])_writer.Provider.ToXml().ToArray().Clone();
        }
        #endregion

        #endregion
    }
}
