
namespace iTin.Export.Model
{
    /// <summary>
    /// Class that defines the result of applying a condition to a data field.
    /// </summary>
    public class ConditionResult
    {
        #region constructor/s

        #region [public] ConditionResult(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ConditionResult" /> class.
        /// </summary>
        public ConditionResult()
        {
            CanApply = false;
            Style = string.Empty;
        }
        #endregion

        #endregion

        #region public static readonly properties

        #region [public] {static} (ConditionResult) Default: Gets a default condition result
        /// <summary>
        /// Gets a default condition result
        /// </summary>
        /// <value>
        /// A default condition result.
        /// </value>
        public static ConditionResult Default => new ConditionResult();
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) CanApply: Gets a value that indicates if the condition can be applied
        /// <summary>
        /// gets a value that indicates if the condition can be applied.
        /// </summary>
        /// <value>
        /// <c>true</c> if the condition has been met and can be applied; otherwise, <c>false</c>,
        /// </value>
        public bool CanApply { get; internal set; }
        #endregion

        #region [public] (string) Style: Gets a value that constains the style to apply
        /// <summary>
        /// Gets a value that constains the style to apply.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains style name to apply.
        /// </value>
        public string Style { get; internal set; }
        #endregion

        #endregion
    }
}
