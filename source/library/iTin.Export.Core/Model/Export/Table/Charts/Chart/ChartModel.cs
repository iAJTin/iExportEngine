
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
    /// Represents a user-defined chart.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Charts</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Chart&gt;
    ///   &lt;Border/&gt;
    ///   &lt;Title/&gt;
    ///   &lt;Legend/&gt;
    ///   &lt;Location/&gt;
    ///   &lt;Axes/&gt;
    ///   &lt;Plots/&gt;
    /// &lt;/Chart&gt;
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Optional</th>
    ///       <th>Description</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the chart. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartModel.BackColor" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred back color. The default is "<c>White</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartModel.Location" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred location of chart. The default is <c>1 1</c>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartModel.Size" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Width and height of the graphic. The default is <c>150 150</c>.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Border" /></term> 
    ///     <description>Reference that contains the visual setting of chart border. Includes visibility, shadow definition, line style, width and color.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Title" /></term> 
    ///     <description>Reference that contains the visual setting of chart title. Includes a text, visibility, orientation, border and font.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Legend" /></term> 
    ///     <description>Reference that contains the visual setting of chart legend. Includes visibility, location, border and font.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Location"/></term>
    ///     <description>Determines the chart location on the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Axes" /></term> 
    ///     <description>Reference that contains the visual setting of the chart axes.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartModel.Plots" /></term> 
    ///     <description>Collection of plots for a chart. Each element represents a chart plot.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
    public partial class ChartModel 
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultBackColor = "White";
        #endregion

        #region private static readonly field members
        private static readonly int[] DefaultSize = { 150, 150 };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] _size;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel _location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartAxesModel _axes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartTitleModel _title;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartPlotsModel _plots;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartBorderModel _border;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartLegendModel _legend;
        #endregion

        #region constructor/s

        #region [public] ChartModel(): Initializes a new instance of this class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ChartModel" /> class.
        /// </summary>
        public ChartModel()
        {
            Size = DefaultSize;
            BackColor = DefaultBackColor;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (KnownChartTypes) ChartType: Gets a value indicating chart type
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating chart type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownChartTypes" /> values.
        /// </value>
        public override KnownChartTypes ChartType => KnownChartTypes.ChartType;
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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

        #region [public] (int[]) Size: Gets or sets width and height of the graphic
        /// <summary>
        /// Gets or sets width and height of the graphic.
        /// </summary>
        /// <value>
        /// An <see cref="T:System.Array"/> of <see cref="T:System.String" /> structure that contains graphical location. The default is <c>150 150</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Chart Size="int int" ...&gt;
        ///   ...
        /// &lt;/Chart&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        [CLSCompliant(false)]
        [DefaultValue(new[] { 150, 150 })]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int[] Size
        {
            get => _size ?? (_size = DefaultSize);
            set
            {
                if (value != null)
                {
                    SentinelHelper.IsTrue(value[0] < 0, "El ancho no puede ser menor que cero");
                    SentinelHelper.IsTrue(value[1] < 0, "El alto no puede ser menor que cero");

                    _size = value;
                }
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        public override bool IsDefault => base.IsDefault &&
                                          Axes.IsDefault &&
                                          Title.IsDefault &&
                                          Border.IsDefault &&
                                          Legend.IsDefault &&
                                          Location.IsDefault &&
                                          Plots.Count.Equals(0) &&
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

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.DataFieldModel.ToString" /> returns a string that includes field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"ChartType={ChartType}, {base.ToString()}";
        }
        #endregion

        #endregion
    }
}
