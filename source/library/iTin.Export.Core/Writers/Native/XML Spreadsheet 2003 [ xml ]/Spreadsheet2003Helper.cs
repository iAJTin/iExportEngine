
namespace iTin.Export.Writers.Native
{
    using System.Globalization;
    using System.Xml;

    using Drawing;
    using Model;

    /// <summary>
    /// Contains common functions for <c>Xml Spreadsheet 2003</c>.
    /// </summary>
    static class Spreadsheet2003Helper
    {
        /// <summary>
        /// Writes error comment.
        /// </summary>
        /// <param name="writer">Xml Writer.</param>
        /// <param name="fieldName">Field name.</param>
        /// <param name="model">Comment model.</param>
        /// <param name="author">Comment author.</param>
        public static void WriteErrorComment(XmlWriter writer, string fieldName, CommentModel model, string author)
        {
            writer.WriteStartElement("Comment");
                writer.WriteAttributeString("ss:Autor", author);
                writer.WriteStartElement("ss:Data");
                    writer.WriteAttributeString("xmlns", string.Empty, null, "http://www.w3.org/TR/REC-html40");

                    writer.WriteStartElement("Font");
                        writer.WriteAttributeString("html:Face", model.Font.Name);
                        writer.WriteAttributeString("html:Size", model.Font.Size.ToString(CultureInfo.InvariantCulture));
                        writer.WriteAttributeString("html:Color", model.Font.GetColor().ToHex());

                        var isBoldComment = model.Font.Bold == YesNo.Yes;
                        if (isBoldComment)
                        {
                            writer.WriteStartElement("B");
                        }

                        var isItalicComment = model.Font.Italic == YesNo.Yes;
                        if (isItalicComment)
                        {
                            writer.WriteStartElement("I");
                        }

                        var isUnderlineComment = model.Font.Underline == YesNo.Yes;
                        if (isUnderlineComment)
                        {
                            writer.WriteStartElement("U");
                        }

                        if (!string.IsNullOrEmpty(model.Text))
                        {
                            writer.WriteString(model.Text);                                
                        }

                        writer.WriteStartElement("xsl:value-of");
                            writer.WriteAttributeString("select", fieldName.Trim());
                        writer.WriteEndElement();

                        if (isUnderlineComment)
                        {
                            writer.WriteEndElement();
                        }

                        if (isItalicComment)
                        {
                            writer.WriteEndElement();
                        }

                        if (isBoldComment)
                        {
                            writer.WriteEndElement();
                        }

                    writer.WriteEndElement();
                writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
