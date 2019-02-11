
namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies 
    /// </summary>
    public enum KnownOperator
    {
        /// <summary>
        /// Value is equals to.
        /// </summary>
        EqualTo,

        /// <summary>
        /// Value is not equals to.
        /// </summary>
        NotEqualTo,

        /// <summary>
        /// Value is less than to.
        /// </summary>
        LessThan,

        /// <summary>
        /// Value is less or equal than to.
        /// </summary>
        LessOrEqualThan,

        /// <summary>
        /// Value is less or equal than to.
        /// </summary>
        GreatherThan,

        /// <summary>
        /// Value is greather or equal than to.
        /// </summary>
        GreatherOrEqualsThan,

        /// <summary>
        /// Value into value-list.
        /// </summary>
        In,

        /// <summary>
        /// Value select into match pattern.
        /// </summary>
        Like,

        /// <summary>
        ///  Value into two values
        /// </summary>
        Beetween,
    }
}
