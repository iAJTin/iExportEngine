
namespace iTin.Export.ComponentModel
{
    using System.Drawing;

    using Model;

    /// <summary>
    /// 
    /// </summary>
    public class FieldValueInformation
    {
        #region public static properties

        #region [public] {static} (FieldValueInformation) Default: Gets defaults instance
        /// <summary>
        /// Gets the default.
        /// </summary>
        /// <value>
        /// The default.
        /// </value>
        public static FieldValueInformation Default => new FieldValueInformation
        {
            Comment = null,
            IsNumeric = false,
            IsNegative = false,
            IsErrorValue = false,
            Value = string.Empty,
            Style = StyleModel.Default,
            NegativeColor = Color.Empty,
            FormattedValue = string.Empty,
        };
        #endregion

        #endregion

        #region public properties

        #region [public] (string) FormattedValue: Gets or sets the data
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public string FormattedValue { get; set; }
        #endregion

        #region [public] (bool) IsErrorValue: 
        /// <summary>
        /// Gets or sets a value indicating whether [is error value].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is error value]; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorValue { get; set; }
        #endregion

        #region [public] (bool) IsNegative: 
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public bool IsNegative { get; set; }
        #endregion

        #region [public] (bool) IsNumeric: 
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public bool IsNumeric { get; set; }
        #endregion

        #region [public] (bool) NegativeColor: 
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public Color NegativeColor { get; set; }
        #endregion

        #region [public] (object) Value: 
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Value { get; set; }
        #endregion

        #region [public] (StyleModel) Style: 
        /// <summary>
        /// Gets or sets 
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public StyleModel Style { get; set; }
        #endregion

        #region [public] (CommentModel) Comment: Gets or sets the comment
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public CommentModel Comment { get; set; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Value=\"{Value}\", Style=\"{Style.Name}\", FormattedValue=\"{FormattedValue}\"";
        }
        #endregion

        #endregion
    }
}
