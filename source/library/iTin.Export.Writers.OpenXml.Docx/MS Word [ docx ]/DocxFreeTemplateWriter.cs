
namespace iTin.Export.Writers.OpenXml.Office
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    using ComponentModel.Writer;
    using Helpers;
    using Model;

    using Novacode;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for Word Template Document Office Open XML (docx format).
    /// </summary>
    /// <remarks>
    ///   <para>This writer is based <c>DocX</c> open source Project</para>
    ///   <para>For more information please see <a href="http://docx.codeplex.com/">http://docx.codeplex.com/</a></para>
    /// </remarks>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "DocxFreeTemplateWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "docx", Description = "Word Office Open XML Template")]
    public class DocxFreeTemplateWriter : BaseWriterDirect
    {
        #region private properties

        #region [private] (TemplateModel) Template: Gets a reference to the current model template.
        /// <summary>
        /// Gets a reference to the current model template.
        /// </summary>
        /// <value>
        /// Reference to the current model template.
        /// </value>
        private TemplateModel Template => (TemplateModel)Provider.Input.Model.Table.Exporter.Current;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Execute(): Generates output in Word Document Office Open XML.
        /// <inheritdoc />
        /// <summary>
        /// Generates output in Word Document Office Open XML.
        /// </summary>
        protected override void Execute()
        {
            var tempTemplate = FileHelper.GetUniqueTempRandomFile();
            var originalTemplate = Provider.Input.Model.ResolveRelativePath(KnownRelativeFilePath.Template);

            File.Copy(originalTemplate, tempTemplate.OriginalString);

            var rows = GetRowData().ToList();
            var sufix = Template.Writer.Settings.FieldSufix;
            var trimmode = Template.Writer.Settings.TrimMode;
            var prefix = Template.Writer.Settings.FieldPrefix;
            var trimField = Template.Writer.Settings.TrimFields == YesNo.Yes;

            foreach (var row in rows)
            {
                using (var stream = StreamHelper.AsMemoryStreamFromFile(tempTemplate.OriginalString))
                {
                    using (var document = DocX.Load(stream))
                    {
                        var attributes = row.Attributes();
                        var templateField = new StringBuilder();
                        foreach (var attribute in attributes)
                        {
                            templateField.Clear();
                            templateField.Append(prefix);
                            templateField.Append(attribute.Name);
                            templateField.Append(sufix);

                            var hasTables = document.Tables.Any();
                            var matches = document.FindUniqueByPattern(templateField.ToString(), RegexOptions.IgnoreCase);
                            if (!matches.Any() && !hasTables)
                            {
                                continue;
                            }

                            var value = attribute.Value;

                            if (trimField)
                            {
                                switch (trimmode)
                                {
                                    case KnownTrimMode.All:
                                        value = value.Trim();
                                        break;

                                    case KnownTrimMode.Start:
                                        value = value.TrimStart();
                                        break;

                                    case KnownTrimMode.End:
                                        value = value.TrimEnd();
                                        break;
                                }
                            }

                            document.ReplaceText(templateField.ToString(), value);
                        }

                        var ms = new MemoryStream();
                        document.SaveAs(ms);
                        Result.Add(ms.ToArray());
                    }
                }
            }

            File.Delete(tempTemplate.OriginalString);
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (IEnumerable<XElement>) GetRowData(): Returns the set of rows to export.
        /// <summary>
        /// Returns the set of rows to export.
        /// </summary>
        /// <returns>
        /// Array than contains a set of rows to export.
        /// </returns>
        private IEnumerable<XElement> GetRowData()
        {
            var rows = Service.RawDataFiltered;
            var rowsCount = rows.Length;

            var data = rows;
            var rowstoShow = Template.Writer.Settings.RecordsToShow;
            switch (rowstoShow)
            {
                case KnownRecordToShow.All:
                    break;

                case KnownRecordToShow.First:
                    data = new[] { rows.FirstOrDefault() };
                    break;

                case KnownRecordToShow.Last:
                    data = new[] { rows.LastOrDefault() };
                    break;

                case KnownRecordToShow.Random:
                    var rnd = new Random();
                    var random = rnd.Next(0, rowsCount - 1);
                    data = new[] { rows[random] };
                    break;
            }

            return data;
        }
        #endregion

        #endregion
    }
}
