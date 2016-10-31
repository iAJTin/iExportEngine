using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Collection of user-defined charts. Each element represents a user-defined chart.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Charts&gt;
    ///   &lt;Chart/&gt;
    ///   &lt;Chart/&gt;
    ///   ...
    /// &lt;/Charts&gt;
    /// </code>
    /// </para>    
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
    /// <example>
    /// <code lang="xml">
    /// &lt;Charts&gt;
    ///   &lt;Chart Location="1 2" Size="500 100" BackColor="LightGray"&gt;
    ///     &lt;Border Show="Yes" Color="Gray" Width="Medium"&gt;            
    ///       &lt;Shadow Show="Yes" Transparency="0.5"/&gt;
    ///     &lt;/Border&gt;
    ///     &lt;Legend Show="Yes"&gt;            
    ///       &lt;Font Name="Calibri" /&gt;          
    ///     &lt;/Legend&gt;
    ///     &lt;Title&gt;
    ///       &lt;Text&gt;Sample Report&lt;/Text&gt;
    ///       &lt;Font Name="Calibri" Color="Navy" Size="22" Bold="Yes"/&gt;
    ///     &lt;/Title&gt;
    ///     &lt;Axes&gt;
    ///       &lt;Primary&gt;
    ///         &lt;Category&gt;
    ///           &lt;Title&gt;
    ///             &lt;Text&gt;Category&lt;/Text&gt;
    ///             &lt;Font Name="Calibri" Bold="Yes"/&gt;                  
    ///           &lt;/Title&gt;
    ///           &lt;Labels Orientation="Downward" Position="Low" Alignment="Left"&gt;                  
    ///             &lt;Font Name="Calibri" Size="8" Color="Red"/&gt;                  
    ///           &lt;/Labels&gt;
    ///         &lt;/Category&gt;
    ///         &lt;Values&gt;
    ///           &lt;Title Show="Yes" Orientation="Vertical"&gt;
    ///             &lt;Text&gt;Value&lt;/Text&gt;
    ///             &lt;Font Name="Calibri" Bold="Yes" Color="Green"/&gt;
    ///           &lt;/Title&gt;
    ///           &lt;Labels Orientation="Downward" Position="Low" Alignment="Left"&gt;
    ///             &lt;Font Name="Calibri" Size="8" Color="Green"/&gt;                
    ///           &lt;/Labels&gt;
    ///         &lt;/Values&gt;
    ///       &lt;/Primary&gt;
    ///     &lt;/Axes&gt;
    ///    &lt;Plots&gt;            
    ///       &lt;Plot Name="Plot1"&gt;
    ///         &lt;Series&gt;
    ///           &lt;Serie Field="CMCUST" Axis="CMCUST" Type="Area3D" Legend="Account" Color="Green"/&gt;                  
    ///           &lt;Serie Field="##LINE" Axis="CMCUST" Type="Area3D" Legend="Line" Color="AntiqueWhite"/&gt;
    ///           &lt;Serie Field="NOCOL" Axis="CMCUST" Type="Area3D" Legend="No/Col" Color="Red"/&gt;            
    ///         &lt;/Series&gt;         
    ///       &lt;/Plot&gt;
    ///     &lt;/Plots&gt;
    ///   &lt;/Chart&gt;       
    /// &lt;/Charts&gt;
    /// </code>
    /// </example>
    public partial class ChartsModel
    {
        public ChartsModel(TableModel parent)
            : base(parent)
        {
        }

        /// <summary>
        /// Validates chart definition list.
        /// </summary>
        public void Validate()
        {
            foreach (var chart in this)
            {
                chart.Plots.Validate();
            }
        }

        protected override void SetOwner(ChartModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
    }
}

////    #region Private Fields
////        private readonly List<ChartModel> list;
////        #endregion

////        #region Constructor/s

////            #region [public] ChartsModel(TableModel): Initializes a new instance of this class.
////            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Charts/Public/Constructors/Constructor[@name="ctor1"]/*'/>
////            public ChartsModel(TableModel parent)
////            {
////                this.list = new List<ChartModel>();
////                this.Parent = parent;
////            }
////            #endregion

////        #endregion

////        #region Public Properties

////            #region [public] (int) Count: 
////            /// <summary>
////            /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.
////            /// </summary>
////            /// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
////            public int Count
////            {
////                get
////                {
////                    return this.list.Count;
////                }
////            }
////            #endregion

////            #region [public] (bool) IsReadOnly: 
////            /// <summary>
////            /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
////            /// </summary>
////            /// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
////            public bool IsReadOnly
////            {
////                get { return false; }
////            }
////            #endregion

////            #region [public] (TableModel) Parent: Gets the parent container of the styles.
////            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Charts/Public/Properties/Property[@name="Parent"]/*'/>
////            [Browsable(false)]
////            public TableModel Parent
////            {
////                get;
////                private set;
////            }
////            #endregion

////        #endregion

////        #region Public Overrides Properties

////            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default.
////            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault.Collection"]/*'/>
////            public override bool IsDefault
////            {
////                get { return !this.Any(); }
////            }
////            #endregion

////        #endregion

////        #region Public Indexers

////            public ChartModel this[int index]
////            {
////                get
////                {
////                    return this.list[index];
////                }
////                set
////                {
////                    this.list[index] = value;
////                }
////            }

////        #endregion

////        #region Public Methods

////            #region [public] (void) Add(ChartModel):
////            /// <summary>
////            /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
////            /// </summary>
////            /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
////            public void Add(ChartModel item)
////            {
////                SentinelHelper.ArgumentNull(item);

////                item.SetOwner(this);
////                this.list.Add(item);
////            }
////            #endregion

////            #region [public] (void) Clear(): 
////            /// <summary>
////            /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
////            /// </summary>
////            public void Clear()
////            {
////                this.list.Clear();
////            }
////            #endregion

////            #region [public] (bool) Contains(ChartModel): Returns a value indicating whether the style exist.
////            public bool Contains(ChartModel item)
////            {
////                return this.list.Contains(item);
////            }
////            #endregion

////            public int IndexOf(ChartModel item)
////            {
////                return this.list.IndexOf(item);
////            }

////            public void Insert(int index, ChartModel item)
////            {
////                this.list.Insert(index, item);
////            }

////            public void RemoveAt(int index)
////            {
////                this.list.RemoveAt(index);
////            }

////            public void CopyTo(ChartModel[] array, int arrayIndex)
////            {
////                this.list.CopyTo(array, arrayIndex);
////            }

////            public bool Remove(ChartModel item)
////            {
////                return this.list.Remove(item);
////            }

////            public IEnumerator<ChartModel> GetEnumerator()
////            {
////                return this.list.GetEnumerator();
////            }

////            IEnumerator IEnumerable.GetEnumerator()
////            {
////                return this.list.GetEnumerator();
////            }

////            /// <summary>
////            /// Validates chart definition list.
////            /// </summary>
////            public void Validate()
////            {
////                foreach (var chart in this)
////                {
////                    chart.Plots.Validate();
////                }
////            }

////        #endregion
////    }
////}
