
namespace iTin.Export.ComponentModel
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Especifica una descripción para un elemento de tipo enumerado.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumDescriptionAttribute : DescriptionAttribute
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.EnumDescriptionAttribute" /> class. 
        /// </summary>
        /// <param name="description">Description text.</param>
        public EnumDescriptionAttribute(string description)
            : base(description)
        {
        }
    }
}
