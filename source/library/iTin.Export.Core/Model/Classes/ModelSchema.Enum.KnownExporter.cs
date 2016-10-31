namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies the known exporters.
    /// </summary>
    public enum KnownExporter
    {
        /// <summary>
        /// Custom Writer, please see <see cref="T:iTin.Export.Model.WriterModel" /> for more information.
        /// </summary>
        Writer,

        /// <summary>
        /// Template Writer, please see <see cref="T:iTin.Export.Model.TemplateModel" /> for more information.
        /// </summary>
        Template,

        /// <summary>
        /// Xslt transform file, please see <see cref="T:iTin.Export.Model.XsltModel" /> for more information.
        /// </summary>
        Xslt
    }
}
