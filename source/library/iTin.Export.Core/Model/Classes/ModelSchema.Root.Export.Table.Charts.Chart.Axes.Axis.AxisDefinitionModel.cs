
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Represents the visual setting of a axis.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Primary</c></strong>, or <strong><c>Secondary</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.AxisModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Category&gt;
    ///   &lt;Labels/&gt;
    ///   &lt;Marks/&gt;
    ///   &lt;Title/&gt;
    ///   &lt;Values/&gt;
    /// &lt;/Category&gt;
    /// </code>
    /// <para>- Or -</para>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Values&gt;
    ///   &lt;Labels/&gt;
    ///   &lt;Marks/&gt;
    ///   &lt;Title/&gt;
    ///   &lt;Values/&gt;
    /// &lt;/Values&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionModel.GridLines" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred grid lines for axis. The default is <see cref="iTin.Export.Model.KnownPlotGridLine.None" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the axis. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.AxisDefinitionModel.Labels" /></term> 
    ///     <description>Reference that contains the visual setting of labels axis.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.AxisDefinitionModel.Marks" /></term> 
    ///     <description>Reference that contains the visual setting of mark axis.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.AxisDefinitionModel.Title" /></term> 
    ///     <description>Reference that contains the visual setting of axis title. Includes a text, visibility, orientation, border and font.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.AxisDefinitionModel.Values" /></term> 
    ///     <description>Reference that contains the visual setting of values axis.</description>
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
    public partial class AxisDefinitionModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownPlotGridLine DefaultGridLines = KnownPlotGridLine.None;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartTitleModel title;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownPlotGridLine gridLines;
          
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionMarksModel marks;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionLabelsModel labels;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionValuesModel values;
        #endregion

        #region constructor/s

        #region [public] AxisDefinitionModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.AxisDefinitionModel" /> class.
        /// </summary>
        public AxisDefinitionModel()
        {
            Show = DefaultShow;
            GridLines = DefaultGridLines;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownPlotGridLine) GridLines: Gets or sets preferred grid lines for axis
        /// <summary>
        /// Gets or sets preferred grid lines for axis.
        /// </summary>
        /// <value>
        /// Preferred grid lines for axis. The default is <see cref="iTin.Export.Model.KnownPlotGridLine.None" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category GridLines="None|Both|Major|Minor" ...&gt;
        /// ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values GridLines="None|Both|Major|Minor" ...&gt;
        /// ...
        /// &lt;/Values&gt;
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
        [DefaultValue(DefaultGridLines)]
        public KnownPlotGridLine GridLines
        {
            get => gridLines;
            set
            {
                SentinelHelper.IsEnumValid(value);

                gridLines = value;
            }
        }
        #endregion

        #region [public] (AxisDefinitionLabelsModel) Labels: Gets or sets a reference that contains the visual setting of labels axis
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of labels axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.AxisDefinitionLabelsModel" /> reference that contains the visual setting of labels axis.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category ...&gt;
        ///   &lt;Labels .../&gt;
        ///   ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values ...&gt;
        ///   &lt;Labels .../&gt;
        ///   ...
        /// &lt;/Values&gt;
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
        public AxisDefinitionLabelsModel Labels
        {
            get
            {
                if (labels == null)
                {
                    labels = new AxisDefinitionLabelsModel();
                }

                labels.SetParent(this);

                return labels;
            }
            set => labels = value;
        }
        #endregion

        #region [public] (AxisDefinitionMarksModel) Marks: Gets or sets a reference that contains the visual setting of mark axis
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of mark axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.AxisDefinitionMarksModel" /> reference that contains the visual setting of mark axis.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category ...&gt;
        ///   &lt;Marks .../&gt;
        ///   ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values ...&gt;
        ///   &lt;Marks .../&gt;
        ///   ...
        /// &lt;/Values&gt;
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
        public AxisDefinitionMarksModel Marks
        {
            get
            {
                if (marks == null)
                {
                    marks = new AxisDefinitionMarksModel();
                }

                marks.SetParent(this);

                return marks;
            }
            set => marks = value;
        }
        #endregion

        #region [public] (AxisModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public AxisModel Parent => parent;
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the axis
        /// <summary>
        /// Gets or sets a value that determines whether displays the axis.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if displays the axis; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category Show="Yes|No" ...&gt;
        ///   ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values Show="Yes|No" ...&gt;
        ///   ...
        /// &lt;/Values&gt;
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
            get => show;
            set
            {
                SentinelHelper.IsEnumValid(value);

                show = value;
            }
        }
        #endregion

        #region [public] (ChartTitleModel) Title: Gets or sets a reference that contains the visual setting of axis title
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of axis title.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ChartTitleModel" /> reference that contains the visual setting of axis title.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category ...&gt;
        ///   &lt;Title .../&gt;
        ///   ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values ...&gt;
        ///   &lt;Title .../&gt;
        ///   ...
        /// &lt;/Values&gt;
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
            get => title ?? (title = new ChartTitleModel());
            set => title = value;
        }
        #endregion

        #region [public] (AxisDefinitionValuesModel) Values: Gets or sets a reference that contains the visual setting of values axis
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of values axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.AxisDefinitionValuesModel" /> reference that contains the visual setting of values axis.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Category ...&gt;
        ///   &lt;Values .../&gt;
        ///   ...
        /// &lt;/Category&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Values ...&gt;
        ///   &lt;Values .../&gt;
        ///   ...
        /// &lt;/Values&gt;
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
        public AxisDefinitionValuesModel Values
        {
            get
            {
                if (values == null)
                {
                    values = new AxisDefinitionValuesModel();
                }

                values.SetParent(this);

                return values;
            }
            set => values = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Labels.IsDefault &&
                                          Marks.IsDefault &&
                                          Title.IsDefault &&
                                          Values.IsDefault &&
                                          Show.Equals(DefaultShow) &&
                                          GridLines.Equals(DefaultGridLines);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(AxisModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(AxisModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
