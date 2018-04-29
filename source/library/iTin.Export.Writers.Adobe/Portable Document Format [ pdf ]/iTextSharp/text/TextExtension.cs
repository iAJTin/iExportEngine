
namespace iTextSharp.text
{
    using System.Drawing.Imaging;
    using System.IO;
    using System.Text;

    using iTin.Export.Helpers;
    using iTin.Export.Model;

    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:iTextSharp.text"/>.
    /// </summary>
    static class TextExtension
    {
        #region [public] {static} (Document) AddLogo(this Document, LogoModel): Adds logo from model to current pdf document
        /// <summary>
        /// Adds logo from model to current pdf document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="logo">Logo model.</param>
        /// <returns>
        /// Returns current pdf document.
        /// </returns>
        public static Document AddLogo(this Document document, LogoModel logo)
        {
            SentinelHelper.ArgumentNull(document);

            if (logo == null)
            {
                return document;
            }

            if (logo.IsDefault)
            {
                return document;
            }

            if (logo.Show == YesNo.No)
            {
                return document;
            }

            System.Drawing.Image imageLogo;
            var found = logo.Image.TryGetImage(out imageLogo);
            if (!found)
            {
                return document;
            }

            var root = logo.Parent.Parent;

            var imagePath = root.Resources.Images[0].Path;
            var imageFileName = Path.GetFileNameWithoutExtension(root.ParseRelativeFilePath(imagePath));

            var modifiedImageFileNamePathBuilder = new StringBuilder();
            modifiedImageFileNamePathBuilder.Append(FileHelper.TinExportTempDirectory);
            modifiedImageFileNamePathBuilder.Append(imageFileName);
            modifiedImageFileNamePathBuilder.Append(".png");

            imageLogo.Save(modifiedImageFileNamePathBuilder.ToString(), ImageFormat.Png);

            var logoWidth = logo.LogoSize.Width == -1
                                ? imageLogo.Width
                                : logo.LogoSize.Width;

            var logoHeight = logo.LogoSize.Height == -1
                                 ? imageLogo.Height
                                 : logo.LogoSize.Height;

            var modifiedLogo = Image.GetInstance(modifiedImageFileNamePathBuilder.ToString());
            modifiedLogo.ScaleAbsolute(logoWidth, logoHeight);

            var logoPosition = logo.Location;
            var positionType = logoPosition.LocationType;
            if (positionType.Equals(KnownElementLocation.ByAlignment))
            {
                document.SetVerticalLocationFrom(logoPosition);

                var x = 0.0f;
                var y = document.PageSize.Height - logoHeight - document.TopMargin;
                var alignMode = ((AlignmentModel)logoPosition.Mode).Horizontal;
                switch (alignMode)
                {
                    case KnownHorizontalAlignment.Center:
                        x = document.PageSize.Left + document.LeftMargin + ((document.PageSize.Width - document.LeftMargin - document.RightMargin - logoWidth) / 2);
                        break;

                    case KnownHorizontalAlignment.Left:
                        x = document.PageSize.Left + document.LeftMargin;
                        break;

                    case KnownHorizontalAlignment.Right:
                        x = document.PageSize.Right - document.RightMargin - logoWidth;
                        break;
                }

                modifiedLogo.SetAbsolutePosition(x, y);
            }

            document.Add(modifiedLogo);

            return document;
        }
        #endregion

        #region [public] {static} (Document) SetMarginsFromModel(this Document, MarginsModel): Sets the margins of document from model
        /// <summary>
        /// Sets the margins of document from model.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="margins">The margins.</param>
        /// <returns>
        /// An <see cref="T:iTextSharp.text.Document"/> reference which contains the margins values.
        /// </returns>
        public static Document SetMarginsFromModel(this Document document, MarginsModel margins)
        {
            SentinelHelper.ArgumentNull(document);
            SentinelHelper.ArgumentNull(margins);

            var units = margins.Units;
            if (units == KnownUnit.Millimeters)
            {
                document.SetMargins(
                    margins.Left/10f/2.54f,
                    margins.Right/10f/2.54f,
                    margins.Top/10f/2.54f,
                    margins.Bottom/10f/2.54f);
            }
            else
            {
                document.SetMargins(margins.Left, margins.Right, margins.Top, margins.Bottom);
            }

            return document;
        }
        #endregion

        #region [public] {static} (Document) SetVerticalLocationFrom(this Document, LocationModel): Sets initial vertical location of a table
        /// <summary>
        /// Sets initial vertical location of a <see cref="T:iTextSharp.text.pdf.PdfPTable" />.
        /// </summary>
        /// <param name="document">Document which receives new position.</param>
        /// <param name="location">Location to apply.</param>
        /// <returns>
        /// A <see cref="T:iTextSharp.text.Document" /> object which contains specified position.
        /// </returns>
        /// <remarks>
        /// If value of <see cref="P:iTin.Export.Model.LocationModel.Mode"/> is <see cref="iTin.Export.Model.KnownElementLocation.ByCoordenates"/>
        /// uses the default configuration, the horizontal alignment is set to center and vertical alignment set to top.
        /// </remarks>
        public static Document SetVerticalLocationFrom(this Document document, LocationModel location)
        {
            var locationType = location.LocationType;
            if (locationType.Equals(KnownElementLocation.ByCoordenates))
            {
                return document;
            }

            var skipLines = ((AlignmentModel)location.Mode).SkipLines;
            for (var r = 1; r <= skipLines; r++)
            {
                document.Add(new Paragraph(" "));
            }

            return document;
        }
        #endregion
    }
}
