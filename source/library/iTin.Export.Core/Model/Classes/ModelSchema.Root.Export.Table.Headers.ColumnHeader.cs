using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    public partial class ColumnHeaderModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultText = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Default";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string from;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string to;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string text;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeadersModel owner;
        #endregion

        #region constructor/s

            #region [public] ColumnHeaderModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ColumnHeaderModel"/> class.
            /// </summary>
            public ColumnHeaderModel()
            {
                Show = DefaultShow;
                Text = DefaultText;
                Style = DefaultStyle;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (string) From: Gets or sets begin column name
            [XmlAttribute]
            public string From
            {
                get
                {
                    return from;
                }
                set
                {
                    ////SentinelHelper.ArgumentNull(value);
                    ////SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    from = value;
                }
            }
            #endregion

            #region [public] (string) To: Gets or sets end column name
            [XmlAttribute]
            public string To
            {
                get
                {
                    return to;
                }
                set
                {
                    ////SentinelHelper.ArgumentNull(value);
                    ////SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    to = value;
                }
            }
            #endregion

            #region [public] (string) Style: Gets or sets style name
            [XmlAttribute]
            public string Style
            {
                get
                {
                    return style;
                }
                set
                {
                    ////SentinelHelper.ArgumentNull(value);
                    ////SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    style = value;
                }
            }
            #endregion

            #region [public] (YesNo) Show: Gets or sets a value indicating whether show column header.
            [XmlAttribute]
            [DefaultValue(DefaultShow)]
            public YesNo Show
            {
                get
                {
                    return show;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    show = value;
                }
            }
            #endregion

            #region [public] (string) Text: Gets or sets text of column header
            [XmlAttribute]
            [DefaultValue(DefaultText)]
            public string Text
            {
                get
                {
                    return text;
                }
                set
                {
                    ////SentinelHelper.ArgumentNull(value);
                    ////SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                    text = value;
                }
            }
            #endregion

            #region [public] (ColumnHeadersModel) Owner: Gets the element that owns this.
            /// <summary>
            /// Gets the element that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
            /// </summary>
            /// <value>
            /// The <see cref="T:iTin.Export.Model.ColumnHeadersModel"/> that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public ColumnHeadersModel Owner
            {
                get { return owner; }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return
                        Text.Equals(DefaultText) &&
                        Show.Equals(DefaultShow) &&
                        Style.Equals(DefaultStyle);
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (StyleModel) GetStyle(): Return the StyleModel for this column.
            /// <summary>
            /// Return the <see cref="T:iTin.Export.Model.StyleModel"/> for this column.
            /// </summary>
            /// <returns>
            /// A <see cref="T:iTin.Export.Model.StyleModel"/> for this column.
            /// </returns>
            public StyleModel GetStyle()
            {
                var columns = Owner;
                var table = columns.Parent;
                var export = table.Parent;
                var exports = export.Owner;
                var resources = exports.Resources;
                var styles = resources.Styles;

                return styles[Style];
            }
            #endregion

            #region [public] (void) SetOwner(ColumnHeadersModel): Sets the element that owns this.
            /// <summary>
            /// Sets the element that owns this <see cref="T:iTin.Export.Model.ColumnHeaderModel"/>.
            /// </summary>
            /// <param name="reference">Reference to owner.</param>
            public void SetOwner(ColumnHeadersModel reference)
            {
                owner = reference;
            }
            #endregion

        #endregion
    }
}
