
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Class[@name="info"]/*' />
    public partial class OutputModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownOutputTarget DefaultTarget = KnownOutputTarget.Windows;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _file;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownOutputTarget _target;
        #endregion

        #region constructor/s

        #region [public] OutputModel(): Initializes a new instance of this class
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Constructors/Constructor[@name="ctor1"]/*'/>
        public OutputModel()
        {
            Target = DefaultTarget;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) EndOfFile: Gets representation for end of file mark
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="EndOfFile"]/*'/>
        [XmlIgnore]
        public string EndOfFile
        {
            get
            {
                switch (Target)
                {
                    case KnownOutputTarget.MacOS:
                        return "\n";

                    default:
                        return string.Empty;
                }
            }
        }
        #endregion

        #region [public] (string) File: Gets or sets the output file name without extension
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="File"]/*'/>
        [Category("Design")]
        [Description("The output file name without extension.")]
        [XmlElement]
        public string File
        {
            get => _file;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(FileHelper.IsValidFileName(value), new InvalidFileNameException(ErrorMessageHelper.ModelFileNameErrorMessage("File", value)));
                _file = value;
            }
        }
        #endregion

        #region [public] (string) NewLineDelimiter: Gets representation for a new line by operating system
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="NewLineDelimiter"]/*'/>
        [XmlIgnore]
        public string NewLineDelimiter
        {
            get
            {
                switch (Target)
                {
                    case KnownOutputTarget.DOS:
                        return Environment.NewLine;

                    case KnownOutputTarget.MacOS:
                        return "\r";

                    default:
                        return Environment.NewLine;
                }
            }
        }
        #endregion

        #region [public] (TableModel) Parent: Parent: Gets the parent container of the output
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="Parent"]/*'/>
        [Browsable(false)]
        public TableModel Parent => _parent;
        #endregion

        #region [public] (string) Path: Gets or sets the output file path. To specify a relative path use the character (~)
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="Path"]/*'/>
        [Category("Design")]
        [XmlElement]
        [Description("The output file path. To specify a relative path use the character (~).")]
        public string Path
        {
            get => _path;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));

                _path = value;
            }
        }
        #endregion

        #region [public] (KnownOutputTarget) Target: Gets or sets a value that determines target operating system
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Output/Public/Properties/Property[@name="Target"]/*'/>
        [XmlAttribute]
        [Category("Design")]
        [Description("Determines target operating system.")]
        [DefaultValue(DefaultTarget)]
        public KnownOutputTarget Target
        {
            get => _target;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _target = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Target.Equals(DefaultTarget);
        #endregion

        #endregion

        #region public methods

        #region [public] (Uri) ToUri(): 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Uri ToUri()
        {
            try
            {
                return new Uri(Parent.Parent.ParseRelativeFilePath(KnownRelativeFilePath.Output));
            }
            catch
            {
                // err - Mostrar error
                throw;
            }
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(TableModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(TableModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
