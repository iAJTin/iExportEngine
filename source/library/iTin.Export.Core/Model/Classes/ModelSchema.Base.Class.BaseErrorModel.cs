using System;
using System.Diagnostics;

namespace iTin.Export.Model
{
    /// <summary>
    /// Base class for different data types errors.
    /// Which acts as the base class for the different data types errors.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different data types errors.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.NumericErrorModel" /></term>
    ///       <description>Reference for numeric data type error settings.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.DatetimeErrorModel" /></term>
    ///       <description>Reference for datetime data type error settings.</description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public partial class BaseErrorModel : ICloneable
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CommentModel comment;
        #endregion

        #region public properties

            #region [public] (CommentModel) Comment: Gets or sets a reference that contains the error comment.
            /// <summary>
            /// Gets or sets a reference that contains the error comment.
            /// </summary>
            /// <value>
            /// The error comment.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Comment&gt;
            ///   &lt;Text/&gt;
            ///   &lt;Font/&gt;
            /// &lt;/Comment&gt;
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
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            /// <example>
            /// In the following example shows how create a new style with a currency data type.
            /// <code lang="xml">
            /// &lt;Style Name="AccountValue"&gt;
            ///   &lt;Content Color="Blue"&gt;
            ///     &lt;Currency Decimals="1" Locale="mk"&gt;
            ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
            ///       &lt;Error Value="-1000"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Text&gt;Database value: &lt;/Text&gt;
            ///           &lt;Font Size="12" Color="Navy"/&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;
            ///     &lt;/Currency&gt;
            ///   &lt;/Content&gt;
            ///   &lt;Font Size="8" Color="White"/&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// <para>Another example for the number data type.</para>
            /// <code lang="xml">
            /// &lt;Style Name="AccountValue"&gt;
            ///   &lt;Content Color="Blue"&gt;
            ///     &lt;Number Decimals="1"&gt;
            ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
            ///       &lt;Error Value="99"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Text&gt;Wrong value: &lt;/Text&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;
            ///     &lt;/Currency&gt;
            ///   &lt;/Content&gt;
            ///   &lt;Font Size="8" Color="White"/&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            public CommentModel Comment
            {
                get
                {
                    return comment ?? (comment = new CommentModel());
                }
                set
                {
                    comment = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return Comment.IsDefault;
                }
            }
        #endregion

        #endregion

        #region public methods

            #region [public] (BaseErrorModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public BaseErrorModel Clone()
            {
                var baseErrorCloned = (BaseErrorModel)MemberwiseClone();
                baseErrorCloned.Comment = Comment.Clone();
                baseErrorCloned.Properties = Properties.Clone();

                return baseErrorCloned;
            }
            #endregion

            #region [public] (void) Combine(BaseErrorModel): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            /// <param name="reference">The reference.</param>
            public void Combine(BaseErrorModel reference)
            {
                Comment.Combine(reference.Comment);
            }
        #endregion

        #endregion

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
            /// <summary>
            /// Creates a new object that is a copy of the current instance.
            /// </summary>
            /// <returns>
            /// A new object that is a copy of this instance.
            /// </returns>
            object ICloneable.Clone()
            {
                return Clone();
            }
            #endregion

        #endregion
    }
}
