
namespace iTin.Export.Model
{
    using System.Collections.Generic;

    using Helpers;

    public partial class ChartSeriesModel
    {
        #region constructor/s

        #region [public] Series(ChartPlotModel): 
        /// <summary>
        /// Initializes a new instance of the <see cref="iTin.Export.Model.ChartSeriesModel"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ChartSeriesModel(ChartPlotModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Validate(this List<BaseDataFieldModel>): Validates serie definition list
        /// <summary>
        /// Validates serie definition list.
        /// </summary>
        /// <exception cref="T:iTin.Export.Model.InvalidSeriesDefinitionException">Thrown if there are serie definition errors.</exception>
        public void Validate()
        {
            var hasFieldErrors = HasFieldErrors(this, out var fieldErrorDictionary);
            if (!hasFieldErrors)
            {
                return;
            }

            var message = ErrorMessageHelper.FormatSeriesErrorMessage(fieldErrorDictionary);
            throw new InvalidSeriesDefinitionException(message);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) HasFieldErrors(IEnumerable<ChartSerieModel>, out Dictionary<FieldModel, List<string>>): Gets a value indicating whether there are errors in serie in the field attribute or axis attribute
        /// <summary>
        /// Gets a value indicating whether there are errors in serie in the field attribute or axis attribute.
        /// </summary>
        /// <param name="series">Serie list.</param>
        /// <param name="errorTable">Dictionary of fields that contains the list of objects with error.</param>
        /// <returns>
        /// <strong>true</strong> if field or axis attributes not found in the list of fields; otherwise, <strong>false</strong>.
        /// </returns>
        /// <remarks>
        /// The parameter <paramref name="errorTable" /> contains a dictionary containing the field and the list of elements whose field is not properly defined.
        /// </remarks>
        private static bool HasFieldErrors(IEnumerable<ChartSerieModel> series, out Dictionary<ChartSerieModel, List<string>> errorTable)
        {
            errorTable = new Dictionary<ChartSerieModel, List<string>>();
            foreach (var serie in series)
            {
                var typeFieldList = new List<string>();

                var field = serie.Owner.Parent.Owner.Parent.Owner.Parent.Fields[serie.Field];
                if (field == null)
                {
                    typeFieldList.Add("Field");
                }

                var axis = serie.Owner.Parent.Owner.Parent.Owner.Parent.Fields[serie.Axis];
                if (axis == null)
                {
                    typeFieldList.Add("Axis");
                }

                var totalFixed = typeFieldList.Count;
                if (totalFixed > 0)
                {
                    errorTable.Add(serie, typeFieldList);
                }
            }

            return errorTable.Count > 0;
        }
        #endregion

        #endregion

        protected override void SetOwner(ChartSerieModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
    }
}
