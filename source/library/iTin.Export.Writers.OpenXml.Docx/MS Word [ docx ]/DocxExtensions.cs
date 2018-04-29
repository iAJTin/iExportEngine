
namespace iTin.Export.Writers.OpenXml.Office
{
    using Helpers;
    using Model;

    using Novacode;

    /// <summary>
    /// Contains common extensions for data model objects.
    /// </summary>
    static class DocxExtensions
    {
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownDocumentOrientation"/> enumeration type to <see cref="T:Novacode.Orientation"/>.
        /// </summary>
        /// <param name="orientation">Orientation value from model.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Orientation" /> value.
        /// </returns>
        public static Orientation ToDocxOrientation(this KnownDocumentOrientation orientation)
        {
            SentinelHelper.IsEnumValid(orientation);

            return orientation == KnownDocumentOrientation.Portrait ? Orientation.Portrait : Orientation.Landscape;
        }
    }
}
