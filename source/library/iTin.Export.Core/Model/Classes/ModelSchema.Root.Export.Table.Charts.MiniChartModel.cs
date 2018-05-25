
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    /// <summary>
    /// Represents a user-defined mini-chart.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Charts</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// <![CDATA[
    /// <MiniChart...>
    ///   <Location/>
    ///   <Axes/>
    ///   <Type/>
    ///   <Properties/>
    /// </Font>
    /// ]]>
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Attribute</term>
    ///     <term>Optional</term>
    ///     <term>Description</term>
    ///     <term>Default</term>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.Field"/></term>
    ///     <term>No</term>
    ///     <term>Name of field that contains data.</term>
    ///     <term></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.EmptyValuesAs"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred action when the field does not contain information.</term>
    ///     <term>The default is <c>Gap</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.Show"/></term>
    ///     <term>Yes</term>
    ///     <term>Determines whether displays the mini-chart.</term>
    ///     <term>The default is <c>Yes</c></term>
    ///   </item>
    /// </list>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartLocationModel"/></term>
    ///     <description>Defines the mini-chart location on the host, this can be by coordinates or by column or by row. You can only choose one of them. If this tag does not define the defaults is by column</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartAxesModel"/></term>
    ///     <description>Defines the mini-chart axes configuration.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MiniChartModel.MiniChartTypeModel"/></term>
    ///     <description>Defines the mini-chart type configuration.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Properties"/></term>
    ///     <description>Reference to custom properties dictionary</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
    ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
    ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
    ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
    ///   </listheader>
    ///   <item>
    ///     <term></term>
    ///     <term></term>
    ///     <term></term>
    ///     <term></term>
    ///   </item>
    /// </list>
    /// A <c><b>X</b></c> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class MiniChartModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const MiniChartEmptyValuesAs DefaultEmptyValueAs = MiniChartEmptyValuesAs.Gap;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartEmptyValuesAs _emptyValuesAs;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel _location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartAxesModel _axes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartTypeModel _type;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartsModel _owner;
        #endregion

        #region constructor/s

        #region [public] MiniChartModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MiniChartModel" /> class.
        /// </summary>
        public MiniChartModel()
        {
            Show = DefaultShow;
            EmptyValueAs = DefaultEmptyValueAs;
            BackColor = DefaultBackColor;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (ChartAxesModel) Axes: Gets or sets a reference that contains the visual setting of the chart axes
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of the chart axes.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ChartAxesModel" /> reference that contains the visual setting of the chart axes.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Axes/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ChartAxesModel Axes
        {
            get
            {
                if (_axes == null)
                {
                    _axes = new ChartAxesModel();
                }

                _axes.SetParent(this);

                return _axes;
            }
            set => _axes = value;
        }
        #endregion

        #region [public] (string) BackColor: Gets or sets preferred back color for this chart
        /// <summary>
        /// Gets or sets preferred back color for this chart.
        /// </summary>
        /// <value>
        /// Preferred back color. The default is "<c>White</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart BackColor="string" ...&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultBackColor)]
        public string BackColor { get; set; }
        #endregion

        #region [public] (ChartBorderModel) Border: Gets or sets a reference that contains the visual setting of chart border
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of chart border.
        /// </summary>
        /// <value>
        /// Reference that contains the visual setting of chart border.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Border/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ChartBorderModel Border
        {
            get => _border ?? (_border = new ChartBorderModel());
            set => _border = value;
        }
        #endregion

        #region [public] (Size) ChartSize: Gets the dimensions of chart
        /// <summary>
        /// Gets the dimensions of chart.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Drawing.Size" /> structure that contains the dimensions of chart measured in pixels.
        /// </value>
        public Size ChartSize => new Size(Size[0], Size[1]);
        #endregion

        #region [public] (ChartLegendModel) Legend: Gets or sets a reference that contains the visual setting of chart legend
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of chart legend.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ChartLegendModel" /> reference that contains the visual setting of chart legend.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Legend/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ChartLegendModel Legend
        {
            get
            {
                if (_legend == null)
                {
                    _legend = new ChartLegendModel();
                }

                _legend.SetParent(this);

                return _legend;
            }
            set => _legend = value;
        }
        #endregion

        #region [public] (LocationModel) Location: Gets or sets a reference which contains the chart location on the host
        /// <summary>
        /// Gets or sets a reference which contains the chart location on the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format.
        /// You can only choose one of the modes. If this tag does not define the defaults is by coordinates
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.LocationModel" /> reference that contains the chart location.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="TEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Location/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public LocationModel Location
        {
            get => _location ?? (_location = new LocationModel());
            set => _location = value;
        }
        #endregion

        #region [public] (ChartsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ChartsModel" /> that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </value>
        [Browsable(false)]
        public ChartsModel Owner => _owner;
        #endregion

        #region [public] (ChartPlotsModel) Plots:  Gets or sets collection of plots for a chart
        /// <summary>
        /// Gets or sets collection of plots for a chart.
        /// </summary>
        /// <value>
        /// Collection of plots for a chart. Each element represents a chart plot.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Plots/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlArrayItem("Plot", typeof(ChartPlotModel))]
        public ChartPlotsModel Plots
        {
            get => _plots ?? (_plots = new ChartPlotsModel(this));
            set => _plots = value;
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the mini-chart
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (ChartTitleModel) Title: Gets or sets a reference that contains the visual setting of chart title
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of chart title.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ChartTitleModel" /> reference that contains the visual setting of chart title.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart ...&gt;
        ///   &lt;Title/&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ChartTitleModel Title
        {
            get
            {
                if (_title == null)
                {
                    _title = new ChartTitleModel();
                }

                _title.SetParent(this);

                return _title;
            }
            set => _title = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Axes.IsDefault &&
                                          Title.IsDefault &&
                                          Border.IsDefault &&
                                          Legend.IsDefault &&
                                          Location.IsDefault &&
                                          Plots.Count.Equals(0) &&
                                          Show.Equals(DefaultShow) &&
                                          Size.SequenceEqual(DefaultSize);
        #endregion

        #endregion

        #region public methods

        #region [public] (Color) GetBackColor(): Gets a reference to the Color structure than represents back color for this chart
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure than represents back color for this chart.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Color" /> structure that represents back color.
        /// </returns> 
        public Color GetBackColor()
        {
            return ColorHelper.GetColorFromString(BackColor);
        }
        #endregion

        #region [public] (void) SetOwner(ChartsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(ChartsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #region [public] (SizeF) SizeToPoints(IntPtr): Converts chart size value in pixels to points for the specified device
        /// <summary>
        /// Converts chart size value in pixels to points for the specified device.
        /// </summary>
        /// <param name="hwnd">Pointer to device.</param>
        /// <returns>
        /// Returns size of chart, in points.
        /// </returns>
        public SizeF SizeToPoints(IntPtr hwnd)
        {
            SizeF points;

            using (var graphics = Graphics.FromHwnd(hwnd))
            {
                points = new SizeF(ChartSize.Width * 72 / graphics.DpiX, ChartSize.Height * 72 / graphics.DpiY);
            }

            return points;
        }
        #endregion

        #endregion
    }
}
