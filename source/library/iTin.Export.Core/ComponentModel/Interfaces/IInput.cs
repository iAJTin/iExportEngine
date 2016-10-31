namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Declares a generic input.
    /// </summary>
    public interface IInput
    {        
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>XML</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if you can create an <strong>XML</strong>; otherwise, <strong>false</strong>.
        /// </value>
        object Data { get; }

        /// <summary>
        /// Gets a reference that contains extended information of this input.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.InputExtendedInformation"/> that contains the extended information about this input.
        /// </value>
        InputExtendedInformation ExtendedInformation { get; }

        /// <summary>
        /// Export to xml 
        /// </summary>
        /// <remarks>
        /// If <see cref="P:iTin.Export.ExportSettings.From" /> is <c>null</c> or <see cref="System.String.Empty"/>, 
        /// always use the first section with <see cref="P:iTin.Export.Model.ExportModel.Current" /> attribute sets to <see cref="iTin.Export.Model.YesNo.Yes"/>.
        /// </remarks>
        /// <param name="settings">Export Settings</param>
        void Export(ExportSettings settings);
    }
}
