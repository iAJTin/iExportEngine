
using iTin.Export.Model;

namespace iTin.Export.Drawing.ComponentModel
{
    /// <summary>
    /// Provides a type converter to convert objects of type <see cref="T:iTin.Export.Model.KnownEffectType" /> to <see cref="T:System.String" />
    /// and from <see cref="T:System.String" /> 'to' <see cref="T:iTin.Export.Model.KnownEffectType" />.
    /// </summary>
    /// <remarks>
    /// This converter obtains the value by reflection from the attribute <see cref="T:iTin.Export.ComponentModel.EnumDescriptionAttribute" /> associated with
    /// the type <see cref="T:iTin.Export.Model.KnownEffectType" />.
    /// </remarks>
    public class EffectTypeConverter : EnumDescriptionConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Drawing.ComponentModel.EffectTypeConverter"/> class for type <see cref="KnownEffectType" />.
        /// </summary>
        public EffectTypeConverter() : base(typeof(KnownEffectType))
        {
        }
    }
}
