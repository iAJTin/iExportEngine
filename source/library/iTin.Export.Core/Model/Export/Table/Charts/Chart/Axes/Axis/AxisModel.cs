
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    /// <summary>
    /// Includes information for the category and value axes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Primary</c></strong><br/>, or <strong><c>Secondary</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Primary&gt;
    ///   &lt;Category/&gt;
    ///   &lt;Values/&gt;
    /// &lt;/Primary&gt;
    /// </code>
    /// <para>- Or -</para>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Secondary&gt;
    ///   &lt;Category/&gt;
    ///   &lt;Values/&gt;
    /// &lt;/Secondary&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.AxisModel.Category" /></term> 
    ///     <description>Reference to information of category axis. Allows you to configure the axis title, the axis labels, axis marks and axis values.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.AxisModel.Values" /></term> 
    ///     <description>Reference to information of values axis. Allows you to configure the axis title, the axis labels, axis marks and axis values.</description>
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
    public partial class AxisModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartAxesModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionModel _values;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionModel _category;
        #endregion

        #region public properties

        #region [public] (AxisDefinitionModel) Category: Gets or sets a reference that contains the visual setting of category axis
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of category axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.AxisDefinitionModel" /> reference that contains the visual setting of category axis. Allows you to configure the axis title, the axis labels, axis marks and axis values.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Primary&gt;
        ///   &lt;Category/&gt;
        ///   ...
        /// &lt;/Primary&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Secondary&gt;
        ///   &lt;Category/&gt;
        ///   ...
        /// &lt;/Secondary&gt;
        /// </code>
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
        public AxisDefinitionModel Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new AxisDefinitionModel();
                }

                _category.SetParent(this);

                return _category;
            }
            set => _category = value;
        }
        #endregion

        #region [public] (ChartAxesModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public ChartAxesModel Parent => _parent;
        #endregion

        #region [public] (AxisDefinitionModel) Values: Gets or sets a reference that contains the visual setting of values axis
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of values axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.AxisDefinitionModel" /> reference that contains the visual setting of values axis. Allows you to configure the axis title, the axis labels, axis marks and axis values.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Primary&gt;
        ///   &lt;Values/&gt;
        ///   ...
        /// &lt;/Primary&gt;
        /// </code>
        /// <para>- Or -</para>
        /// <para>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Secondary&gt;
        ///   &lt;Values/&gt;
        ///   ...
        /// &lt;/Secondary&gt;
        /// </code>
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
        public AxisDefinitionModel Values
        {
            get
            {
                if (_values == null)
                {
                    _values = new AxisDefinitionModel();
                }

                _values.SetParent(this);

                return _values;
            }
            set => _values = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Values.IsDefault && Category.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ChartAxesModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(ChartAxesModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
