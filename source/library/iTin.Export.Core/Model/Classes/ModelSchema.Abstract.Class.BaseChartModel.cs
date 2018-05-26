
namespace iTin.Export.Model
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    public partial class BaseChartModel
    {
        //#region private members
        //[DebuggerBrowsable(DebuggerBrowsableState.Never)]
        //private string _color;
        //#endregion

        //#region public properties

        //#region [public] (string) Color: Gets or sets preferred serie color
        ///// <summary>
        ///// Gets or sets preferred serie color.
        ///// </summary>
        ///// <value>
        ///// Preferred font color.
        ///// </value>
        //[XmlAttribute]
        //public string Color
        //{
        //    get => GetStaticBindingValue(_color);
        //    set
        //    {
        //        SentinelHelper.ArgumentNull(value);

        //        _color = value;
        //    }
        //}
        //#endregion

        //#endregion

        //#region public override properties

        //#region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        ///// <inheritdoc />
        ///// <summary>
        ///// Gets a value indicating whether this instance contains the default.
        ///// </summary>
        ///// <value>
        ///// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        ///// </value>
        //public override bool IsDefault => base.IsDefault &&
        //                                  string.IsNullOrEmpty(Color);
        //#endregion

        //#endregion

        //#region public override methods

        //#region [public] {override} (string) ToString(): Returns a string that represents the current object
        ///// <inheritdoc />
        ///// <summary>
        ///// Returns a string that represents the current object.
        ///// </summary>
        ///// <returns>
        ///// A <see cref="T:System.String" /> that represents the current object.
        ///// </returns>
        ///// <remarks>
        ///// This method <see cref="M:iTin.Export.Model.DataFieldModel.ToString" /> returns a string that includes field alias.
        ///// </remarks>
        //public override string ToString()
        //{
        //    return $"Color=\"{Color}\"";
        //}
        //#endregion

        //#endregion

        //#region public methods

        //#region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this mini-chart serie
        ///// <summary>
        ///// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this mini-chart serie.
        ///// </summary>
        ///// <returns>
        ///// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        ///// </returns>
        //public Color GetColor()
        //{
        //    return ColorHelper.GetColorFromString(Color);
        //}
        //#endregion

        //#endregion    
    }
}
