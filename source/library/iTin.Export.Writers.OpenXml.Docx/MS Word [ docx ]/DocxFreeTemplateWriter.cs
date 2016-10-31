using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

using iTin.Export.ComponentModel;
using iTin.Export.Helper;
using iTin.Export.Model;

using Novacode;

namespace iTin.Export.Writers.OpenXml.Office
{
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
        #region Private Properties

            #region [private] (TemplateModel) Template: Gets a reference to the current model template.
            /// <summary>
            /// Gets a reference to the current model template.
            /// </summary>
            /// <value>
            /// Reference to the current model template.
            /// </value>
            private TemplateModel Template
            {
                get { return (TemplateModel)Adapter.DataModel.Data.Table.Exporter.Current; }
            }
            #endregion

        #endregion

        #region Protected Override Methods

            #region [protected] {override} (void) Execute(): Generates output in Word Document Office Open XML.
            /// <summary>
            /// Generates output in Word Document Office Open XML.
            /// </summary>
            protected override void Execute()
            {
                var tempTemplate = FileHelper.GetUniqueTempRandomFile();
                var originalTemplate = Adapter.DataModel.Data.ParseRelativeFilePath(KnownRelativeFilePath.Template);

                File.Copy(originalTemplate, tempTemplate.OriginalString);

                var rows = GetRowData();
                var sufix = Template.Writer.Settings.FieldSufix;
                var trimmode = Template.Writer.Settings.TrimMode;
                var prefix = Template.Writer.Settings.FieldPrefix;
                var trimField = Template.Writer.Settings.TrimFields == YesNo.Yes;
                using (var stream = StreamHelper.AsMemoryStreamFromFile(tempTemplate.OriginalString))
                {
                    using (var document = DocX.Load(stream))
                    {
                        foreach (var row in rows)
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
                        }

                        document.Save();                                                         
                    }  
                 
                    Result.Add(stream.ToArray());
                }

                File.Delete(tempTemplate.OriginalString);
            }
            #endregion

        #endregion

        #region Private Methods

            #region [private] (IEnumerable<XElement>) GetRowData(): Returns the set of rows to export.
            /// <summary>
            /// Returns the set of rows to export.
            /// </summary>
            /// <returns>
            /// Array than contains a set of rows to export.
            /// </returns>
            private IEnumerable<XElement> GetRowData()
            {
                var rows = Adapter.ToXml().ToArray();
                var rowsCount = rows.Count();

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
