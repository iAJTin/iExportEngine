using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;

using iTin.Export.Drawing.Helper;
using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Represents a user-defined chart.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Charts</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartsModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
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
    public partial class ChartModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultBackColor = "White";
        #endregion

        #region private static readonly field members
        private static readonly int[] DefaultSize = { 150, 150 };
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int[] size;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartsModel owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartAxesModel axes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartTitleModel title;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartPlotsModel plots;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartBorderModel border;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartLegendModel legend;
        #endregion

        #region constructor/s

            #region [public] ChartModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ChartModel" /> class.
            /// </summary>
            public ChartModel()
            {
                Show = DefaultShow;
                Size = DefaultSize;
                BackColor = DefaultBackColor;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (ChartAxesModel) Axes: Gets or sets a reference that contains the visual setting of the chart axes.
            /// <summary>
            /// Gets or sets a reference that contains the visual setting of the chart axes.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.Model.ChartAxesModel" /> reference that contains the visual setting of the chart axes.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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
                    if (axes == null)
                    {
                        axes = new ChartAxesModel();
                    }

                    axes.SetParent(this);

                    return axes;
                }
                set
                {
                    axes = value;
                }
            }
            #endregion

            #region [public] (string) BackColor: Gets or sets preferred back color for this chart.
            /// <summary>
            /// Gets or sets preferred back color for this chart.
            /// </summary>
            /// <value>
            /// Preferred back color. The default is "<c>White</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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

            #region [public] (ChartBorderModel) Border: Gets or sets a reference that contains the visual setting of chart border.
            /// <summary>
            /// Gets or sets a reference that contains the visual setting of chart border.
            /// </summary>
            /// <value>
            /// Reference that contains the visual setting of chart border.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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
                get
                {
                    return border ?? (border = new ChartBorderModel());
                }
                set
                {
                    border = value;
                }
            }
            #endregion

            #region [public] (Size) ChartSize: Gets the dimensions of chart.
            /// <summary>
            /// Gets the dimensions of chart.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.Drawing.Size" /> structure that contains the dimensions of chart measured in pixels.
            /// </value>
            public Size ChartSize
            {
                get
                {
                    return new Size(Size[0], Size[1]);
                }
            }

            #endregion

            #region [public] (ChartLegendModel) Legend: Gets or sets a reference that contains the visual setting of chart legend.
            /// <summary>
            /// Gets or sets a reference that contains the visual setting of chart legend.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.Model.ChartLegendModel" /> reference that contains the visual setting of chart legend.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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
                    if (legend == null)
                    {
                        legend = new ChartLegendModel();
                    }

                    legend.SetParent(this);

                    return legend;
                }
                set
                {
                    legend = value;
                }
            }
            #endregion

            #region [public] (LocationModel) Location: Gets or sets a reference which contains the chart location on the host.
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
                get
                {
                    return location ?? (location = new LocationModel());
                }
                set
                {
                    location = value;
                }
            }
            #endregion

            #region [public] (ChartsModel) Owner: Gets the element that owns this.
            /// <summary>
            /// Gets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
            /// </summary>
            /// <value>
            /// The <see cref="T:iTin.Export.Model.ChartsModel" /> that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
            /// </value>
            [Browsable(false)]
            public ChartsModel Owner
            {
                get { return owner; }
            }
            #endregion

            #region [public] (ChartPlotsModel) Plots:  Gets or sets collection of plots for a chart.
            /// <summary>
            /// Gets or sets collection of plots for a chart.
            /// </summary>
            /// <value>
            /// Collection of plots for a chart. Each element represents a chart plot.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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
                get
                {
                    return plots ?? (plots = new ChartPlotsModel(this));
                }
                set
                {
                    plots = value;
                }
            }
            #endregion

            #region [public] (int[]) Size: Gets or sets width and height of the graphic.
            /// <summary>
            /// Gets or sets width and height of the graphic.
            /// </summary>
            /// <value>
            /// An <see cref="T:System.Array"/> of <see cref="T:System.String" /> structure that contains graphical location. The default is <c>150 150</c>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Chart Size="int int" ...&gt;
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
            [CLSCompliant(false)]
            [DefaultValue(new[] { 150, 150 })]
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public int[] Size
            {
                get
                {
                    return size ?? (size = DefaultSize);
                }
                set
                {
                    if (value != null)
                    {
                        SentinelHelper.IsTrue(value[0] < 0, "El ancho no puede ser menor que cero");
                        SentinelHelper.IsTrue(value[1] < 0, "El alto no puede ser menor que cero");

                        size = value;
                    }
                }
            }
            #endregion

            #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the chart.
            /// <summary>
            /// Gets or sets a value that determines whether displays the chart.
            /// </summary>
            /// <value>
            /// <see cref="iTin.Export.Model.YesNo.Yes" /> if display the chart; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Chart Show="Yes|No" ...&gt;
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
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultShow)]
            public YesNo Show
            {
                get
                {
                    return show;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    show = value;
                }
            }
            #endregion

            #region [public] (ChartTitleModel) Title: Gets or sets a reference that contains the visual setting of chart title.
            /// <summary>
            /// Gets or sets a reference that contains the visual setting of chart title.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.Model.ChartTitleModel" /> reference that contains the visual setting of chart title.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
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
                    if (title == null)
                    {
                        title = new ChartTitleModel();
                    }

                    title.SetParent(this);

                    return title;
                }
                set
                {
                    title = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
            public override bool IsDefault
            {
                get
                {
                    return
                        Axes.IsDefault &&
                        Title.IsDefault &&
                        Border.IsDefault &&
                        Legend.IsDefault &&
                        Location.IsDefault &&
                        Plots.Count.Equals(0) &&
                        Show.Equals(DefaultShow) &&
                        Size.SequenceEqual(DefaultSize);
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (Color) GetBackColor(): Gets a reference to the Color structure than represents back color for this chart.
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

            #region [public] (void) SetOwner(ChartsModel): Sets the element that owns this.
            /// <summary>
            /// Sets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
            /// </summary>
            /// <param name="reference">Reference to owner.</param>
            public void SetOwner(ChartsModel reference)
            {
                owner = reference;
            }
            #endregion

            #region [public] (SizeF) SizeToPoints(IntPtr): Converts chart size value in pixels to points for the specified device.
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
