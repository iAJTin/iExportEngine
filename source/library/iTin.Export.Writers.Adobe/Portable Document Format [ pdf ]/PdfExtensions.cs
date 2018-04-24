
namespace iTin.Export.Writers.Adobe
{
    using iTextSharp.text;

    using Model;

    /// <summary>
    /// Contains common extensions for data model objects.
    /// </summary>
    static class PdfExtensions
    {
        /// <summary>
        /// Converts the enumerated type <see cref="T:iTin.Export.Model.KnownDocumentSize"/> to the appropriate value for the specified page size.
        /// </summary>
        /// <param name="size">Size to convert.</param>
        /// <returns>
        /// A <see cref="T:iTextSharp.text.Rectangle" /> value that represents page size for the specified size.
        /// </returns>
        public static Rectangle ToPageSize(this KnownDocumentSize size)
        {
            var pageSize = PageSize.A4;
            switch (size)
            {
                case KnownDocumentSize.A0:
                    pageSize = PageSize.A0;
                    break;

                case KnownDocumentSize.A1:
                    pageSize = PageSize.A1;
                    break;

                case KnownDocumentSize.A2:
                    pageSize = PageSize.A2;
                    break;

                case KnownDocumentSize.A3:
                    pageSize = PageSize.A3;
                    break;

                case KnownDocumentSize.A5:
                    pageSize = PageSize.A5;
                    break;

                case KnownDocumentSize.A6:
                    pageSize = PageSize.A6;
                    break;

                case KnownDocumentSize.A7:
                    pageSize = PageSize.A7;
                    break;

                case KnownDocumentSize.A8:
                    pageSize = PageSize.A8;
                    break;

                case KnownDocumentSize.A9:
                    pageSize = PageSize.A9;
                    break;

                case KnownDocumentSize.A10:
                    pageSize = PageSize.A10;
                    break;

                case KnownDocumentSize.Executive:
                    pageSize = PageSize.EXECUTIVE;
                    break;

                case KnownDocumentSize.HalfLetter:
                    pageSize = PageSize.HALFLETTER;
                    break;

                case KnownDocumentSize.Letter:
                    pageSize = PageSize.LETTER;
                    break;

                case KnownDocumentSize.Note:
                    pageSize = PageSize.NOTE;
                    break;

                case KnownDocumentSize.PostCard:
                    pageSize = PageSize.POSTCARD;
                    break;
            }

            return pageSize;
        }
    }
}
