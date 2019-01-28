
using System.Runtime.InteropServices;

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
    using OfficeOpenXml.Sparkline;

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

        #region [private] (HostModel) Host: Gets a reference to the current host model
        /// <summary>
        /// Gets a reference to the current host model.
        /// </summary>
        /// <value>
        /// Reference to the current host model.
        /// </value>
        private HostModel Host => Resources.Hosts[Table.Host];
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

        //#region [private] (ModelService) Service: Gets service reference to render
        ///// <summary>
        ///// Gets service reference to render.
        ///// </summary>
        ///// <value>
        ///// The service.
        ///// </value>
        //public ModelService Service => ModelService.Instance;
        //#endregion

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
                    var rows = Service.RawDataFiltered;
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
                    var rowsCount = rows.Length;
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

                            worksheet.AddColumnGroupFromModel(columnHeader);                            
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

                        var showHyperLink = header.HyperLink.Show == YesNo.Yes;
                        if (!showHyperLink)
                        {
                            continue;
                        }
                        
                        string tooltip;
                        if (header.HyperLink.Tooltip.Equals(KnownHyperLinkTooltip.FieldName.ToString()))
                        {
                            tooltip = BaseDataFieldModel.GetFieldNameFrom(header.Parent);
                        }
                        else if (header.HyperLink.Tooltip.Equals(KnownHyperLinkTooltip.FieldAlias.ToString()))
                        {
                            tooltip = header.Parent.Alias;
                        }
                        else
                        {
                            tooltip = header.HyperLink.Tooltip;
                        }

                        var hyperLinkStyle = header.Style ?? StyleModel.NameOfDefaultStyle;
                        if (!header.HyperLink.Style.Equals("Current"))
                        {
                            hyperLinkStyle = header.HyperLink.Style;
                        }

                        var hyperLinkType = header.HyperLink.Current.GetType().Name;
                        switch (hyperLinkType)
                        {
                            case "WebHyperLink":
                                var webHyperLink = (WebHyperLink) header.HyperLink.Current;
                                cell.Hyperlink = new ExcelHyperLink(webHyperLink.Address); //, tooltip);                                
                                //cell.StyleName = hyperLinkStyle;
                                break;
                        }
                    }
                    #endregion

                    #region add data
                    if (hasFieldHeaders)
                    {
                        y++;
                    }

                    var conditions = Table.Conditions.Items.ToList();
                    var hasConditions = conditions.Any();
                    var fieldDictionary = new Dictionary<BaseDataFieldModel, int>(); 
                    for (var row = 0; row < rowsCount; row++)
                    {                        
                        var rowData = rows[row];

                        Service.SetCurrentRow(row);
                        for (var col = 0; col < items.Count; col++)
                        {
                            Service.SetCurrentCol(col);

                            var field = items[col];
                            field.DataSource = rowData;

                            Service.SetCurrentField(field);

                            var value = field.Value.GetValue(Provider.SpecialChars);
                            var valueLenght = value.FormattedValue.Length;
                            var cell = worksheet.Cells[y + row, x + col];
                            cell.Value = value.Value;                        
                            cell.AddErrorComment(value);

                            if (hasConditions)
                            {
                                foreach (var condition in conditions)
                                {
                                    if (condition.Active == YesNo.No)
                                    {
                                        continue;
                                    }

                                    var styleToApply = condition.Apply();
                                    if (styleToApply == null)
                                    {
                                        continue;
                                    }

                                    cell.StyleName = styleToApply;
                                }
                            }
                            else
                            {
                                cell.StyleName = row.IsOdd()
                                    ? $"{value.Style.Name}_Alternate"
                                    : value.Style.Name ?? StyleModel.NameOfDefaultStyle;
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
                            worksheet.Cells.AutoFitColumns(0); 
                        }
                        catch (Exception)
                        {
                            // ignored
                        }

                        worksheet.AutoFitGroupColumns(fieldDictionary, this);
                    }
                    #endregion

                    #region add charts
                    var genericCharts = Table.Charts;
                    foreach (var genericChart in genericCharts)
                    {
                        if (genericChart.Show == YesNo.No)
                        {
                            continue;
                        }

                        if (genericChart.ChartType == KnownChartTypes.ChartType)
                        {
                            var chart = (ChartModel) genericChart;
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
                        else
                        {
                            var miniChart = (MiniChartModel) genericChart;

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

                            if (hasBottomAggregates)
                            {
                                dataSerieY++;
                            }

                            var item = items[miniChart.Field];
                            if (item == null)
                            {
                                continue;
                            }

                            Point offset = Point.Empty;
                            var locationModel = miniChart.Location;
                            switch (locationModel.LocationType)
                            {
                                case KnownMiniChartElementPosition.ByColumn:
                                    offset = new Point(0, ((ByColumnLocationModel)locationModel.Mode).Offset);
                                    break;

                                case KnownMiniChartElementPosition.ByRow:
                                    offset = new Point(((ByRowLocationModel)locationModel.Mode).Offset, 0);
                                    break;

                                case KnownMiniChartElementPosition.ByCoordenates:
                                    offset = ((CoordenatesModel)locationModel.Mode).TableCoordenates;
                                    break;

                                case KnownMiniChartElementPosition.Relative:
                                    offset = ((CoordenatesModel)locationModel.Mode).TableCoordenates;
                                    break;
                            }

                            var fieldColumnIndex = tableLocation.X + items.IndexOf(item) + 1;
                            var locationRange = ExcelCellBase.GetAddress(rowsCount + dataSerieY + offset.Y + 1, fieldColumnIndex + offset.X);
                            var dataRange = ExcelCellBase.GetAddress(dataSerieY + 1, fieldColumnIndex, rowsCount + dataSerieY, fieldColumnIndex);

                            // Apply Cell size                           
                            if (miniChart.CellSize.Width != -1)
                            {
                                var minichartColumn = fieldColumnIndex + offset.X;
                                worksheet.Column(minichartColumn).Width = miniChart.CellSize.Width;
                            }

                            if (miniChart.CellSize.Height != -1)
                            {
                                var minichartRow = rowsCount + dataSerieY + offset.Y + 1;
                                worksheet.Row(minichartRow).Height = miniChart.CellSize.Height;
                            }

                            // Create Minichart
                            var sparkline = worksheet.SparklineGroups.Add(
                                miniChart.Type.Active.ToEppeSparklineType(), 
                                worksheet.Cells[locationRange], 
                                worksheet.Cells[dataRange]);

                            sparkline.DisplayHidden = miniChart.DisplayHidden == YesNo.Yes;
                            sparkline.ColorSeries.SetColor(miniChart.Type.Column.Serie.GetColor());
                            sparkline.DisplayEmptyCellsAs = miniChart.EmptyValueAs.ToEppeDisplayBlanksAs();

                            // Axes
                            // Horizontal axis
                            sparkline.RightToLeft = miniChart.Axes.Horizontal.RightToLeft == YesNo.Yes;
                            if (miniChart.Axes.Horizontal.Show == YesNo.Yes)
                            {
                                sparkline.DisplayXAxis = true;
                                sparkline.ColorAxis.SetColor(miniChart.Axes.Horizontal.GetColor());
                            }

                            sparkline.DateAxisRange = null;
                            var isHorizontalDateAxis = miniChart.Axes.Horizontal.IsDateAxis;
                            if (isHorizontalDateAxis)
                            {
                                var horizontalAxisField = miniChart.Axes.Horizontal.GetAxisField();
                                if (horizontalAxisField != null)
                                {
                                    var dateFielColumnIndex = tableLocation.X + items.IndexOf(horizontalAxisField) + 1;
                                    var dateFieldRange = ExcelCellBase.GetAddress(dataSerieY + 1, dateFielColumnIndex, rowsCount + dataSerieY, dateFielColumnIndex);
                                    sparkline.DateAxisRange = worksheet.Cells[dateFieldRange];
                                }
                            }

                            // Vertical axis
                            var maxVerticalAxisIsAuto = miniChart.Axes.Vertical.Max.Equals("Automatic");
                            sparkline.MaxAxisType = maxVerticalAxisIsAuto
                                ? eSparklineAxisMinMax.Individual
                                : eSparklineAxisMinMax.Custom;

                            var minVerticalAxisIsAuto = miniChart.Axes.Vertical.Min.Equals("Automatic");
                            sparkline.MinAxisType = minVerticalAxisIsAuto
                                ? eSparklineAxisMinMax.Individual
                                : eSparklineAxisMinMax.Custom;

                            if (!maxVerticalAxisIsAuto)
                            {
                                sparkline.ManualMax = double.Parse(miniChart.Axes.Vertical.Max);
                            }

                            if (!minVerticalAxisIsAuto)
                            {
                                sparkline.ManualMin = double.Parse(miniChart.Axes.Vertical.Min);
                            }                            

                            // Points
                            switch (miniChart.Type.Active)
                            {
                                case KnownMiniChartType.Column:
                                    if (!miniChart.Type.Column.Points.Low.IsDefault)
                                    {
                                        sparkline.Low = true;
                                        sparkline.ColorLow.SetColor(miniChart.Type.Column.Points.Low.GetColor());
                                    }

                                    if (!miniChart.Type.Column.Points.First.IsDefault)
                                    {
                                        sparkline.First = true;
                                        sparkline.ColorFirst.SetColor(miniChart.Type.Column.Points.First.GetColor());
                                    }

                                    if (!miniChart.Type.Column.Points.High.IsDefault)
                                    {
                                        sparkline.High = true;
                                        sparkline.ColorHigh.SetColor(miniChart.Type.Column.Points.High.GetColor());
                                    }

                                    if (!miniChart.Type.Column.Points.Last.IsDefault)
                                    {
                                        sparkline.Last = true;
                                        sparkline.ColorLast.SetColor(miniChart.Type.Column.Points.Last.GetColor());
                                    }

                                    if (!miniChart.Type.Column.Points.Negative.IsDefault)
                                    {
                                        sparkline.Negative = true;
                                        sparkline.ColorNegative.SetColor(miniChart.Type.Column.Points.Negative.GetColor());
                                    }
                                    break;

                                case KnownMiniChartType.Line:

                                    sparkline.LineWidth = double.Parse(miniChart.Type.Line.Serie.Width);

                                    if (!miniChart.Type.Line.Points.Low.IsDefault)
                                    {
                                        sparkline.Low = true;
                                        sparkline.ColorLow.SetColor(miniChart.Type.Line.Points.Low.GetColor());
                                    }

                                    if (!miniChart.Type.Line.Points.First.IsDefault)
                                    {
                                        sparkline.First = true;
                                        sparkline.ColorFirst.SetColor(miniChart.Type.Line.Points.First.GetColor());
                                    }

                                    if (!miniChart.Type.Line.Points.High.IsDefault)
                                    {
                                        sparkline.High = true;
                                        sparkline.ColorHigh.SetColor(miniChart.Type.Line.Points.High.GetColor());
                                    }

                                    if (!miniChart.Type.Line.Points.Last.IsDefault)
                                    {
                                        sparkline.Last = true;
                                        sparkline.ColorLast.SetColor(miniChart.Type.Line.Points.Last.GetColor());
                                    }

                                    if (!miniChart.Type.Line.Points.Negative.IsDefault)
                                    {
                                        sparkline.Negative = true;
                                        sparkline.ColorNegative.SetColor(miniChart.Type.Line.Points.Negative.GetColor());
                                    }

                                    if (!miniChart.Type.Line.Points.Markers.IsDefault)
                                    {
                                        sparkline.Markers = true;
                                        sparkline.ColorNegative.SetColor(miniChart.Type.Line.Points.Markers.GetColor());
                                    }
                                    break;

                                case KnownMiniChartType.WinLoss:
                                    if (!miniChart.Type.WinLoss.Points.Low.IsDefault)
                                    {
                                        sparkline.Low = true;
                                        sparkline.ColorLow.SetColor(miniChart.Type.WinLoss.Points.Low.GetColor());
                                    }

                                    if (!miniChart.Type.WinLoss.Points.First.IsDefault)
                                    {
                                        sparkline.First = true;
                                        sparkline.ColorFirst.SetColor(miniChart.Type.WinLoss.Points.First.GetColor());
                                    }

                                    if (!miniChart.Type.WinLoss.Points.High.IsDefault)
                                    {
                                        sparkline.High = true;
                                        sparkline.ColorHigh.SetColor(miniChart.Type.WinLoss.Points.High.GetColor());
                                    }

                                    if (!miniChart.Type.WinLoss.Points.Last.IsDefault)
                                    {
                                        sparkline.Last = true;
                                        sparkline.ColorLast.SetColor(miniChart.Type.WinLoss.Points.Last.GetColor());
                                    }

                                    if (!miniChart.Type.WinLoss.Points.Negative.IsDefault)
                                    {
                                        sparkline.Negative = true;
                                        sparkline.ColorNegative.SetColor(miniChart.Type.WinLoss.Points.Negative.GetColor());
                                    }
                                    break;
                            }
                        }
                    }
                    #endregion

                    #region add document information

                    var document = Host.Document;

                    #region sets document view
                    worksheet.View.SetDocumentViewFromModel(document);
                    #endregion

                    #region sets document metadata
                    worksheet.Workbook.Properties.SetDocumentMetadataFromModel(document.Metadata);
                    #endregion

                    #region sets document header/footer
                    worksheet.HeaderFooter.SetDocumentHeaderFromModel(document.Header);
                    worksheet.HeaderFooter.SetDocumentFooterFromModel(document.Footer);
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
                    var printAreaRange =
                        ExcelCellBase.GetAddress(
                            1,
                            1,
                            printAreaRangeY2 + rowsCount - 1,
                            location.X + items.Count - 1,
                            true);

                    worksheet.PrinterSettings.PaperSize = document.Size.ToEppPaperSize();
                    worksheet.PrinterSettings.Orientation = document.Orientation.ToEppOrientation();
                    worksheet.PrinterSettings.SetMarginsFromModel(document.Margins);
                    worksheet.PrinterSettings.PrintArea = worksheet.Cells[printAreaRange];
                    worksheet.PrinterSettings.RepeatRows = worksheet.Cells[repeatRowsRange];
                    #endregion

                    #endregion

                    #region add freeze panes
                    if (Host.Document.View == KnownDocumentView.Normal)
                    {
                        if (Table.FreezePanesPoint.X != 1 && Table.FreezePanesPoint.Y != 1)
                        {
                            worksheet.View.FreezePanes(Table.FreezePanesPoint.Y, Table.FreezePanesPoint.X);
                        }
                    }
                    #endregion

                    ////var range1 = worksheet.Cells["A1:H501"];
                    ////var wsPivot = worksheet.Workbook.Worksheets.Add("PivotSimple");
                    ////var pivotTable1 = wsPivot.PivotTables.Add(wsPivot.Cells["A1"], range1, "PerEmploee");

                    ////pivotTable1.RowFields.Add(pivotTable1.Fields[3]);
                    ////var dataField = pivotTable1.DataFields.Add(pivotTable1.Fields[5]);
                    ////dataField.Format = "#,##0";
                    ////pivotTable1.DataOnRows = true;

                    ////var chartp = wsPivot.Drawings.AddChart("PivotChart", eChartType.Pie, pivotTable1);
                    ////chartp.SetPosition(1, 0, 4, 0);
                    ////chartp.SetSize(600, 400);

                    //var hl = new ExcelHyperLink("Statistics!A1", "Statistics");
                    //hl.

                    //chartp.

                    //var wsPivot2 = pck.Workbook.Worksheets.Add("PivotDateGrp");
                    //var pivotTable2 = wsPivot2.PivotTables.Add(wsPivot2.Cells["A3"], dataRange, "PerEmploeeAndQuarter");

                    //pivotTable2.RowFields.Add(pivotTable2.Fields["Name"]);

                    ////Add a rowfield
                    //var rowField = pivotTable2.RowFields.Add(pivotTable2.Fields["OrderDate"]);

                    ////This is a date field so we want to group by Years and quaters. This will create one additional field for years.
                    //rowField.AddDateGrouping(eDateGroupBy.Years | eDateGroupBy.Quarters);

                    ////Get the Quaters field and change the texts
                    //var quaterField = pivotTable2.Fields.GetDateGroupField(eDateGroupBy.Quarters);
                    //quaterField.Items[0].Text = "<"; //Values below min date, but we use auto so its not used
                    //quaterField.Items[1].Text = "Q1";
                    //quaterField.Items[2].Text = "Q2";
                    //quaterField.Items[3].Text = "Q3";
                    //quaterField.Items[4].Text = "Q4";
                    //quaterField.Items[5].Text = ">"; //Values above max date, but we use auto so its not used

                    ////Add a pagefield
                    //var pageField = pivotTable2.PageFields.Add(pivotTable2.Fields["Title"]);

                    ////Add the data fields and format them
                    //dataField = pivotTable2.DataFields.Add(pivotTable2.Fields["SubTotal"]);
                    //dataField.Format = "#,##0";
                    //dataField = pivotTable2.DataFields.Add(pivotTable2.Fields["Tax"]);
                    //dataField.Format = "#,##0";
                    //dataField = pivotTable2.DataFields.Add(pivotTable2.Fields["Freight"]);
                    //dataField.Format = "#,##0";

                    ////We want the datafields to appear in columns
                    //pivotTable2.DataOnRows = false;

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
