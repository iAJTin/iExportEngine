using System.Diagnostics;
using System.Globalization;

using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Contains resolver for xlsx formulas.
    /// </summary>
    public class ExcelFormulaResolver
    {
        #region Field Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FieldAggregateModel model;
        #endregion

        #region Constructor/s

            #region [public] ExcelFormulaResolver(FieldAggregateModel): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.ExcelFormulaResolver" /> class.
            /// </summary>
            /// <param name="aggregate">Aggregate's data.</param>
            public ExcelFormulaResolver(FieldAggregateModel aggregate)
            {
                model = aggregate;
            }
            #endregion

        #endregion

        #region Public Properties

            #region [public] (int) EndRow: Gets or sets a value that represents the end row of the range.
            /// <summary>
            /// Gets or sets a value that represents the end row of the range.
            /// </summary>
            /// <value>
            /// End row of the range.
            /// </value>
            public int EndRow { private get; set; }
            #endregion

            #region [public] (YesNo) HasAutofilter: Gets or sets a value indicating whether the auto filter is enabled.
            /// <summary>
            /// Gets or sets a value indicating whether the auto filter is enabled.
            /// </summary>
            /// <value>
            /// <c>true</c> if auto filter is enabled; otherwise, <c>false</c>.
            /// </value>
            public YesNo HasAutoFilter { private get; set; }
            #endregion

            #region [public] (int) StartRow: Gets or sets a value that represents the start row of the range.
            /// <summary>
            /// Gets or sets a value that represents the start row of the range.
            /// </summary>
            /// <value>
            /// Start row of the range.
            /// </value>
            public int StartRow { private get; set; }
            #endregion

        #endregion
            
        #region Public Methods

            #region [public] (string) Resolve(): Returns string containing aggregate's formula.
            /// <summary>
            /// Returns string containing aggregate's formula.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> containing the formula.
            /// </returns>
            public string Resolve()
            {
                const string Pattern = "SUBTOTAL({0},R[{1}]C:R[{2}]C)";

                var type = int.MaxValue;
                var result = string.Empty;
                if (model.AggregateType != KnownAggregateType.None)
                {
                    if (model.AggregateType != KnownAggregateType.Text)
                    {
                        switch (model.AggregateType)
                        {
                            case KnownAggregateType.Average:
                                type = HasAutoFilter == YesNo.Yes ? 101 : 1;
                                break;

                            case KnownAggregateType.Count:
                                type = HasAutoFilter == YesNo.Yes ? 103 : 3;
                                break;

                            case KnownAggregateType.Max:
                                type = HasAutoFilter == YesNo.Yes ? 104 : 4;
                                break;

                            case KnownAggregateType.Min:
                                type = HasAutoFilter == YesNo.Yes ? 105 : 5;
                                break;

                            case KnownAggregateType.Sum:
                                type = HasAutoFilter == YesNo.Yes ? 109 : 9;
                                break;
                        }

                        result = string.Format(CultureInfo.InvariantCulture, Pattern, type, StartRow, EndRow);
                    }
                    else
                    {
                        result = model.Text;
                    }
                }

                return result;
            }
            #endregion

        #endregion
    }
}
