
namespace iTin.Export.Writers.OpenXml.Office
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    using OfficeOpenXml;
    using OfficeOpenXml.Drawing.Chart;

    using ComponentModel;
    using ComponentModel.Writer;
    using Model;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for Office Open XML (xlsx format).
    /// </summary>
    /// <remarks>
    ///   <para>This writer is based <c>EPPlus</c> open source Project</para>
    ///   <para>For more information please see <a href="http://epplus.codeplex.com/">http://epplus.codeplex.com/</a></para>
    /// </remarks>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "XlsxTabularWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "xlsx", Description = "Excel Office Open XML Writer")]
    public class XlsxTabularWriter : BaseWriterDirect
    {
        #region private properties

        #region [public] (HostModel) Host: Gets a reference to the current host model
        /// <summary>
        /// Gets a reference to the current host model.
        /// </summary>
        /// <value>
        /// Reference to the current host model.
        /// </value>
        public HostModel Host => Resources.Hosts[Table.Host];
        #endregion

        #region [private] (GlobalResourcesModel) Resources: Gets a reference to the model global resources
        /// <summary>
        /// Gets a reference to the model global resources.
        /// </summary>
        /// <value>
        /// Reference to the model global resources.
        /// </value>
        private GlobalResourcesModel Resources => Provider.Input.Resources;
        #endregion

        #region [private] (TableModel) Table: Gets a reference to the model table
        /// <summary>
        /// Gets a reference to the model table.
        /// </summary>
        /// <value>
        /// Reference to the model table.
        /// </value>
        private TableModel Table => Provider.Input.Model.Table;
        #endregion

        #region [private] (Point) TableLocation: Gets a reference to the location table
        /// <summary>
        /// Gets a reference to the location table.
        /// </summary>
        /// <value>
        /// Reference to the location table.
        /// </value>
        private Point TableLocation
        {
            get
            {
                var location = Table.Location;
                return location.LocationType == KnownElementLocation.ByAlignment
                    ? new Point(1, 1)
                    : ((CoordenatesModel) location.Mode).TableCoordenates;
            }
        }
        #endregion

        #region [private] (string) WorkSheetName: Gets the name of the sheet we are creating
        /// <summary>
        /// Gets the name of the sheet we are creating.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> containing the name of the sheet.
        /// </value>
        private string WorkSheetName
        {
            get
            {
                var name = "NoName";
                if (!string.IsNullOrEmpty(Table.Alias))
                {
                    name = Table.Alias;
                }

                var lenghtName = name.Length;
                if (lenghtName > 31)
                {
                    name = name.Substring(0, 31);
                }

                return name;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Execute(): Generates output in Office Open Xml Excel format
        /// <inheritdoc />
        /// <summary>
        /// Generates output in Office Open Xml Excel format.
        /// </summary>
        protected override void Execute()
        {
            MemoryStream stream = null;

            try
            {
                stream = new MemoryStream();
                using (var excel = new ExcelPackage(stream))
                {
                    #region destroy stream
                    stream = null;
                    #endregion

                    #region initialize
                    var items = Table.Fields;
                    var location = TableLocation;
                    var x = location.X;
                    var y = location.Y;
                    #endregion

                    #region get target data
                    var rows = Provider.ToXml().ToArray();
                    #endregion

                    #region add worksheet
                    var worksheet = excel.Workbook.Worksheets.Add(WorkSheetName);
                    worksheet.View.ShowGridLines = Table.ShowGridLines == YesNo.Yes;
                    #endregion

                    #region add styles
                    excel.Workbook.Styles.CreateFromModel(Resources.Styles);
                    #endregion

                    #region has logo?
                    worksheet.AppendLogo(Table.Logo);
                    #endregion

                    #region add top aggregates
                    var rowsCount = rows.Count();
                    var columnHeaders = Table.Headers;
                    var hasColumnheaders = columnHeaders.Any();

                    var topAggregates = items.GetRange(KnownAggregateLocation.Top).ToList();
                    var hasTopAggregates = topAggregates.Any();
                    if (hasTopAggregates)
                    {
                        foreach (var field in topAggregates)
                        {
                            var aggregate = field.Aggregate;
                            var formula = new ExcelFormulaResolver(aggregate)
                            {
                                StartRow = hasColumnheaders && Table.ShowColumnHeaders == YesNo.Yes ? 3 : 2,
                                EndRow = hasColumnheaders && Table.ShowColumnHeaders == YesNo.Yes ? rowsCount + 2 : rowsCount + 1,
                                HasAutoFilter = Table.AutoFilter,
                            };

                            var column = items.IndexOf(field);
                            var cell = worksheet.Cells[y, x + column];
                            cell.StyleName = aggregate.Style ?? StyleModel.NameOfDefaultStyle;

                            var type = aggregate.AggregateType;
                            if (type == KnownAggregateType.Text)
                            {
                                cell.Value = formula.Resolve();
                            }
                            else
                            {
                                cell.FormulaR1C1 = formula.Resolve();
                            }
                        }
                    }
                    #endregion

                    #region add column headers
                    if (Table.ShowColumnHeaders == YesNo.Yes)
                    {
                        if (hasTopAggregates)
                        {
                            y++;
                        }

                        foreach (var columnHeader in columnHeaders)
                        {
                            var cell = worksheet.GetRangeFromModel(y, columnHeader);
                            cell.Merge = true;
                            cell.StyleName = columnHeader.Style ?? StyleModel.NameOfDefaultStyle;
                            cell.Merge = columnHeader.Show == YesNo.Yes;
                            cell.Value = columnHeader.Show == YesNo.Yes ? columnHeader.Text : string.Empty;
                        }
                    }
                    #endregion

                    #region add headers
                    if (hasColumnheaders)
                    {
                        y++;
                    }

                    var fieldHeaders = items.GetRange(YesNo.Yes).ToList();
                    var hasFieldHeaders = fieldHeaders.Any();
                    foreach (var field in fieldHeaders)
                    {
                        var header = field.Header;
                        var column = items.IndexOf(field);

                        var cell = worksheet.Cells[y, x + column];
                        cell.Value = field.Alias;
                        cell.StyleName = header.Style ?? StyleModel.NameOfDefaultStyle;
                    }
                    #endregion

                    List<BaseConditionModel> conditionsToApply = new List<BaseConditionModel>();
                    Dictionary<string, Dictionary<BaseConditionModel, int>> conditionsToApplyByField = null;

                    bool hasConditions = Table.Conditions.Keys.Any();
                    if (hasConditions)
                    {
                        conditionsToApply.AddRange(
                            from key in Table.Conditions.Keys
                            select Resources.Conditions.FirstOrDefault(i => i.Key == key)
                            into candidateCondition
                            let existCandidateCondition = candidateCondition != null
                            where existCandidateCondition
                            select candidateCondition);

                        conditionsToApplyByField = conditionsToApply.Pivot(i => i.Field, i => i, i => i.Count());
                    }

                    #region add data
                    if (hasFieldHeaders)
                    {
                        y++;
                    }

                    var fieldCondition = conditionsToApply.FirstOrDefault().Field;
                    var firstSwapStyleToApply = ((WhenChangeConditionModel)conditionsToApplyByField[fieldCondition].FirstOrDefault(i => i.Key.Field == fieldCondition).Key).FirstSwapStyle;
                    var secondSwapStyleToApply = ((WhenChangeConditionModel)conditionsToApplyByField[fieldCondition].FirstOrDefault(i => i.Key.Field == fieldCondition).Key).SecondSwapStyle;
                    var fieldDictionary = new Dictionary<BaseDataFieldModel, int>();
                    var styleToApply = firstSwapStyleToApply;
                    for (var row = 0; row < rowsCount; row++)
                    {                        
                        var rowData = rows[row];
                        var rowPreviousData = row > 0 ? rows[row - 1] : null;
                        var rowNextData = row < rowsCount - 1 ? rows[row + 1] : null;

                        string conditionFieldValue = null;
                        var fieldValue = rowData.Attribute(fieldCondition).Value;
                        if (row > 0)
                        {
                            conditionFieldValue = rowPreviousData.Attribute(fieldCondition).Value;
                        }

                        ModelService.Instance.SetCurrentRow(row);
                        for (var col = 0; col < items.Count; col++)
                        {
                            ModelService.Instance.SetCurrentCol(col);

                            var field = items[col];
                            field.DataSource = rowData;

                            ModelService.Instance.SetCurrentField(field);

                            var value = field.Value.GetValue(Provider.SpecialChars);
                            var valueLenght = value.FormattedValue.Length;
                            var cell = worksheet.Cells[y + row, x + col];
                            cell.Value = value.Value;                        
                            cell.AddErrorComment(value);

                            if (fieldValue != conditionFieldValue && conditionFieldValue!=null)
                            {
                                if (col == 0)
                                {
                                    styleToApply = styleToApply == firstSwapStyleToApply
                                        ? secondSwapStyleToApply
                                        : firstSwapStyleToApply;
                                }

                                cell.StyleName = styleToApply;
                            }
                            else
                            {
                                if (hasConditions)
                                {
                                    cell.StyleName = styleToApply;
                                }
                                else
                                {
                                    cell.StyleName = row.IsOdd()
                                        ? $"{value.Style.Name}{AlternateStyleNameSufix}" ??
                                          StyleModel.NameOfDefaultStyle
                                        : value.Style.Name ?? StyleModel.NameOfDefaultStyle;
                                }
                            }

                            cell.Style.WrapText = field.FieldType == KnownFieldType.Group;

                            if (!fieldDictionary.ContainsKey(field))
                            {
                                fieldDictionary.Add(field, valueLenght);
                            }
                            else
                            {
                                var entry = fieldDictionary[field];
                                if (valueLenght > entry)
                                {
                                    fieldDictionary[field] = valueLenght;
                                }
                            }
                        }
                    }
                    #endregion

                    #region add bottom aggregates
                    var fieldsWithBottomAggregates = items.GetRange(KnownAggregateLocation.Bottom).ToList();
                    var hasBottomAggregates = fieldsWithBottomAggregates.Any();
                    if (hasBottomAggregates)
                    {
                        foreach (var field in fieldsWithBottomAggregates)
                        {
                            var aggregate = field.Aggregate;
                            var formula = new ExcelFormulaResolver(aggregate)
                            {
                                EndRow = -1,
                                StartRow = -rowsCount,
                                HasAutoFilter = Table.AutoFilter,
                            };

                            var column = items.IndexOf(field);
                            var cell = worksheet.Cells[y + rowsCount, x + column];
                            cell.StyleName = aggregate.Style ?? StyleModel.NameOfDefaultStyle;

                            var type = aggregate.AggregateType;
                            if (type == KnownAggregateType.Text)
                            {
                                cell.Value = formula.Resolve();
                            }
                            else
                            {
                                cell.FormulaR1C1 = formula.Resolve();
                            }
                        }
                    }
                    #endregion

                    #region add blocklines
                    var blocklines = Provider.Input.Model.BlockLines;
                    var hasBlockLines = blocklines.Any();
                    if (hasBlockLines)
                    {
                        foreach (var blockline in blocklines)
                        {
                            if (blockline.Show == YesNo.No)
                            {
                                continue;
                            }

                            var blocklineLocation = blockline.Location.LocationType.Equals(KnownElementLocation.ByAlignment)
                                    ? new Point(1, 1)
                                    : ((CoordenatesModel)blockline.Location.Mode).TableCoordenates;

                            var dy = 0;
                            var blocklineY = blocklineLocation.Y;
                            var blocklineX = blocklineLocation.X;
                            var keyLines = blockline.Items.Keys;
                            foreach (var keyLine in keyLines)
                            {
                                var line = Resources.Lines.GetBy(keyLine);
                                if (line.Show == YesNo.No)
                                {
                                    continue;
                                }

                                var times = line.Repeat == 0 ? 1 : line.Repeat;
                                for (var i = 1; i <= times; i++)
                                {
                                    int merge;
                                    var dx = 0;
                                    ExcelRange cell;
                                    var lineType = line.LineType;
                                    switch (lineType)
                                    {
                                        case KnownLineType.EmptyLine:
                                            var emptyLine = (EmptyLineModel)line;
                                            merge = emptyLine.Merge;
                                            if (merge > 0)
                                            {
                                                var range = ExcelCellBase.GetAddress(blocklineY + dy, blocklineX, blocklineY + dy, blocklineX + merge - 1);
                                                cell = worksheet.Cells[range];
                                                cell.Merge = true; 
                                            }
                                            else
                                            {
                                                cell = worksheet.Cells[blocklineY + dy, blocklineX];
                                            }

                                            cell.StyleName = line.Style;
                                            break;
                                            
                                        case KnownLineType.TextLine:
                                            var textLine = (TextLineModel)line;
                                            var itemss = textLine.Items;
                                            foreach (var item in itemss)
                                            {
                                                if (item.Show == YesNo.No)
                                                {
                                                    continue;                                                        
                                                }

                                                merge = item.Merge;
                                                if (merge > 0)
                                                {
                                                    var range = 
                                                        ExcelCellBase
                                                            .GetAddress(
                                                                blocklineY + dy,
                                                                blocklineX + dx, 
                                                                blocklineY + dy, 
                                                                blocklineX + dx + merge - 1);
                                                    cell = worksheet.Cells[range];                                                    
                                                    cell.Merge = true;
                                                }
                                                else
                                                {
                                                    cell = worksheet.Cells[blocklineY + dy, blocklineX + dx];
                                                }

                                                cell.StyleName = 
                                                    string.IsNullOrEmpty(item.Style)
                                                        ? (item.Owner.Style ?? StyleModel.Default.Name)
                                                        : item.Style;

                                                var text = item.Value;
                                                cell.Value = text;

                                                dx++;
                                                if (merge > 0)
                                                {
                                                    dx += merge - 1;
                                                }
                                        }

                                        break;
                                    }  
                                                                             
                                    dy++;
                                }
                            }                                    
                        }
                    }
                    #endregion

                    #region add autofilter
                    if (Table.AutoFilter == YesNo.Yes)
                    {
                        if (hasFieldHeaders)
                        {
                            worksheet.Cells[y - 1, x, y - 1, x + items.Count - 1].AutoFilter = true;
                        }
                        else
                        {
                            worksheet.Cells[worksheet.Dimension.Address].AutoFilter = true;
                        }
                    }
                    #endregion

                    #region autofitcolumns?
                    if (Table.AutoFitColumns == YesNo.Yes)
                    {
                        try
                        {
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns(1);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }

                        worksheet.AutoFitGroupColumns(fieldDictionary, this);
                    }
                    #endregion

                    #region add charts
                    var charts = Table.Charts;
                    foreach (var chart in charts)
                    {
                        if (chart.Show == YesNo.No)
                        {
                            continue;
                        }

                        ExcelChart mainchart = null;
                        var plots = chart.Plots;
                        foreach (var plot in plots)
                        {
                            // Calculate y-coordenates
                            var tableLocation = TableLocation;
                            tableLocation.Offset(-1, -1);

                            var dataSerieY = tableLocation.Y;
                            if (hasTopAggregates)
                            {
                                dataSerieY++;
                            }

                            if (hasColumnheaders)
                            {
                                dataSerieY++;
                            }

                            if (hasFieldHeaders)
                            {
                                dataSerieY++;
                            }

                            // Series data, name
                            var series = plot.Series;
                            foreach (var serie in series)
                            {
                                var item = items[serie.Field];
                                if (item == null)
                                {
                                    continue;
                                }

                                var axis = items[serie.Axis];
                                if (axis == null)
                                {
                                    continue;
                                }

                                // Create chart
                                ExcelChart workchart;
                                if (plot.UseSecondaryAxis.Equals(YesNo.No))
                                {
                                    if (mainchart == null)
                                    {
                                        mainchart = worksheet.Drawings.AddChart(serie.Field, serie.ChartType.ToEppChartType());
                                        mainchart.Name = plot.Name;
                                    }

                                    workchart = mainchart;
                                }
                                else
                                {
                                    workchart = mainchart.PlotArea.ChartTypes.Add(serie.ChartType.ToEppChartType());
                                    workchart.UseSecondaryAxis = true;
                                    workchart.XAxis.Deleted = false;
                                }

                                var axisColumnIndex = tableLocation.X + items.IndexOf(axis) + 1;
                                var fieldColumnIndex = tableLocation.X + items.IndexOf(item) + 1;
                                var sr = workchart.Series.Add(
                                    ExcelCellBase.GetAddress(dataSerieY + 1, fieldColumnIndex, rowsCount + dataSerieY, fieldColumnIndex),
                                    ExcelCellBase.GetAddress(dataSerieY + 1, axisColumnIndex, rowsCount + dataSerieY, axisColumnIndex));
                                sr.Header = serie.Name;
                            }
                        }

                        mainchart.FormatFromModel(chart);
                    }
                    #endregion

                    #region sets page orientation, margins and size
                    var printAreaRangeY2 = location.Y;
                    var repeatRowsRangeY2 = printAreaRangeY2;
                    if (hasFieldHeaders)
                    {
                        printAreaRangeY2++;
                    }

                    if (hasTopAggregates)
                    {
                        printAreaRangeY2++;
                        repeatRowsRangeY2++;
                    }

                    if (hasBottomAggregates)
                    {
                        printAreaRangeY2++;
                    }

                    var repeatRowsRange = $"{1}:{repeatRowsRangeY2}";
                    var printAreaRange = ExcelCellBase.GetAddress(1, 1, printAreaRangeY2 + rowsCount, location.X + items.Count - 1, true);

                    var document = Host.Document;
                    worksheet.PrinterSettings.PaperSize = document.Size.ToEppPaperSize();
                    worksheet.PrinterSettings.Orientation = document.Orientation.ToEppOrientation();
                    worksheet.PrinterSettings.SetMarginsFromModel(document.Margins);
                    worksheet.PrinterSettings.PrintArea = worksheet.Cells[printAreaRange];
                    worksheet.PrinterSettings.RepeatRows = worksheet.Cells[repeatRowsRange];
                    #endregion

                    #region save
                    Result.Add(excel.GetAsByteArray());
                    #endregion
                }
            }
            finally
            {
                stream?.Dispose();
            }
        }
        #endregion

        #endregion
    }
}
