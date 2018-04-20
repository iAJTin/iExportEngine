
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    /// <summary>
    /// Represents the visual setting for axes of a chart. Includes information of primary and secondary axes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Chart</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Axes&gt;
    ///   &lt;Primary/&gt;
    ///   &lt;Secondary/&gt;
    /// &lt;/Axes&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartAxesModel.Primary" /></term> 
    ///     <description>Reference to information of primary axes. Includes information for the category and value axes.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartAxesModel.Secondary" /></term> 
    ///     <description>Reference to information of secondary axes. Includes information for the category and value axes.</description>
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
    public partial class ChartAxesModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisModel primary;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisModel secondary;
        #endregion

        #region public properties

        #region [public] (ChartModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public ChartModel Parent => parent;
        #endregion

        #region [public] (AxisModel) Primary: Gets or sets a reference to information of primary axes
        /// <summary>
        /// Gets or sets a reference to information of primary axes.
        /// </summary>
        /// <value>
        /// An <see cref="T:iTin.Export.Model.AxisModel" /> reference that contains information of primary axes. Includes information for the category and value axes.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Axes&gt;
        ///   &lt;Primary/&gt;
        ///   ...
        /// &lt;/Axes&gt;
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
        public AxisModel Primary
        {
            get
            {
                if (primary == null)
                {
                    primary = new AxisModel();
                }

                primary.SetParent(this);

                return primary;
            }
            set => primary = value;
        }
        #endregion

        #region [public] (AxisModel) Secondary: Gets or sets a reference to information of secondary axes
        /// <summary>
        /// Gets or sets a reference to information of secondary axes.
        /// </summary>
        /// <value>
        /// An <see cref="T:iTin.Export.Model.AxisModel" /> reference that contains information of secondary axes. Includes information for the category and value axes.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Axes&gt;
        ///   &lt;Secondary/&gt;
        ///   ...
        /// &lt;/Axes&gt;
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
        public AxisModel Secondary
        {
            get
            {
                if (secondary == null)
                {
                    secondary = new AxisModel();
                }

                secondary.SetParent(this);

                return secondary;
            }
            set => secondary = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        public override bool IsDefault => Primary.IsDefault && Secondary.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ChartModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(ChartModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
