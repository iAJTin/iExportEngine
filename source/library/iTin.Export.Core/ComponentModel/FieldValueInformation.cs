using System.Drawing;
using System.Globalization;
using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    public class FieldValueInformation
    {
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

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public string FormattedValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is error value].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is error value]; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorValue { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public bool IsNegative { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public bool IsNumeric { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public Color NegativeColor { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public StyleModel Style { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public CommentModel Comment { get; set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Value=\"{0}\", Style=\"{1}\", FormattedValue=\"{2}\"", Value, Style.Name, FormattedValue);
        }
    }
}
