using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Contains resolver for non-tabular writers.
    /// </summary>
    public class NonTabularFormulaResolver
    {
        #region Field Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FieldAggregateModel model;
        #endregion

        #region Constructor/s

            #region [public] NonTabularFormulaResolver(FieldAggregateModel): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.NonTabularFormulaResolver" /> class.
            /// </summary>
            /// <param name="aggregate">Aggregate's data.</param>
            public NonTabularFormulaResolver(FieldAggregateModel aggregate)
            {
                model = aggregate;
            }
            #endregion

        #endregion

        #region Public Properties

            #region [public] (IEnumerable<string>) Data: Gets or sets a value that represents data values.
            /// <summary>
            /// Gets or sets a value that represents data values.
            /// </summary>
            /// <value>
            /// Data values.
            /// </value>
            public IEnumerable<string> Data { private get; set; }
            #endregion

        #endregion
            
        #region Public Methods

            #region [public] (string) Resolve(): Returns a string containing the result.
            /// <summary>
            /// Returns a string containing the result.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> containing the result.
            /// </returns>
            public string Resolve()
            {
                var result = string.Empty;

                var type = model.AggregateType;
                if (type == KnownAggregateType.None)
                {
                    return result;
                }

                if (type != KnownAggregateType.Text)
                {
                    if (type == KnownAggregateType.Count)
                    {
                        var noEmptyEnumerable = Data.Where(n => !string.IsNullOrEmpty(n));
                        result = noEmptyEnumerable.Count().ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        try
                        {
                            var data = Data.Where(
                                n =>
                                {
                                    decimal retNum;
                                    return decimal.TryParse(n.Replace(",", "."), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out retNum);
                                });

                            var arrayData = new Collection<decimal>();
                            foreach (var item in data)
                            {
                                decimal ret;
                                decimal.TryParse(item.Replace(",", "."), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out ret);
                                arrayData.Add(ret);
                            }

                            var hasElements = arrayData.Any();
                            switch (type)
                            {
                                case KnownAggregateType.Average:
                                    result = !hasElements
                                                ? "Err"
                                                : arrayData.Average().ToString(CultureInfo.InvariantCulture);
                                    break;

                                case KnownAggregateType.Count:
                                    result = !hasElements
                                                ? "0"
                                                : arrayData.Count().ToString(CultureInfo.InvariantCulture);
                                    break;

                                case KnownAggregateType.Max:
                                    result = !hasElements
                                                ? "0"
                                                : arrayData.Max().ToString(CultureInfo.InvariantCulture);
                                    break;

                                case KnownAggregateType.Min:
                                    result = !hasElements
                                                ? "0"
                                                : arrayData.Min().ToString(CultureInfo.InvariantCulture);
                                    break;

                                case KnownAggregateType.Sum:
                                    result = !hasElements
                                                ? "0"
                                                : arrayData.Sum().ToString(CultureInfo.InvariantCulture);
                                    break;
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    result = model.Text;
                }

                return result;
            }
            #endregion

        #endregion
    }
}
