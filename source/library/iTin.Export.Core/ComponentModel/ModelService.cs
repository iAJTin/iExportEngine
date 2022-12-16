
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace iTin.Export.ComponentModel
{
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

        /// <summary>
        /// 
        /// </summary>
        public int CurrentCol { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public BaseDataFieldModel CurrentField { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int CurrentRow { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ExportModel CurrentModel => _writer.Provider.Input.Model;

        /// <summary>
        /// 
        /// </summary>
        public IProvider Provider => _writer.Provider;

        /// <summary>
        /// 
        /// </summary>
        public ExportsModel Root => _writer.Provider.Input.GetRoot();

        /// <summary>
        /// 
        /// </summary>
        public XElement[] RawData { get; private set ;}

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

        /// <summary>
        /// 
        /// </summary>
        public ReferencesModel References => _writer.Provider.Input.References;

        /// <summary>
        /// 
        /// </summary>
        public GlobalResourcesModel Resources => _writer.Provider.Input.Resources;

        #endregion

        #region public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void SetCurrentCol(int col)
        {            
            CurrentCol = col;
        }

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

        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        public override string ToString() => $"Model=\"{CurrentModel.Name}\", Writer=\"{_writer.WriterMetadata.Name}\", Provider=\"{Provider.ProviderMetadata.Name}\"";

        #endregion

        #region internal methods

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
    }
}
