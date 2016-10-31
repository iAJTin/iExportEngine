using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Property/Class[@name="info"]/*'/>
    public partial class PropertyModel : ICloneable
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertiesModel _owner;
        #endregion

        #region public properties

            #region [public] (string) Name: Gets or sets name of custom property.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Property/Public/Properties/Property[@name="Name"]/*'/>
            [XmlAttribute]
            public string Name { get; set; }
            #endregion

            #region [public] (string) Value: Gets or sets value of custom property.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Property/Public/Properties/Property[@name="Value"]/*'/>
            [XmlAttribute]
            public string Value { get; set; }
            #endregion

            #region [public] (PropertiesModel) Owner: Gets the element that owns this.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Property/Public/Properties/Property[@name="Owner"]/*'/>
            [XmlIgnore]
            public PropertiesModel Owner
            {
                get { return _owner; }
            }
        #endregion

        #endregion

        #region public methods

            #region [public] (PropertyModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public PropertyModel Clone()
            {
                return (PropertyModel)MemberwiseClone();
            }
            #endregion

            #region [public] (void) SetOwner(PropertiesModel): Sets the element that owns this.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Property/Internal/Methods/Method[@name="SetOwner"]/*'/>
            internal void SetOwner(PropertiesModel reference)
            {
                _owner = reference;
            }
        #endregion

        #endregion

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
            /// <summary>
            /// Creates a new object that is a copy of the current instance.
            /// </summary>
            /// <returns>
            /// A new object that is a copy of this instance.
            /// </returns>
            object ICloneable.Clone()
            {
                return Clone();
            }
            #endregion

        #endregion
    }
}
