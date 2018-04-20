
namespace iTin.Export.Writers.Native
{
    /// <summary>
    /// Contains <stong>Xml Spreadsheet 2003</stong> patterns expressions.
    /// </summary>
    static class KnownSpreadsheetExpression
    {        
        /// <summary>
        /// Print area data range name 
        /// </summary>
        public const string PrintAreaNamedRange = "Print_Area";

        /// <summary>
        /// Data range name
        /// </summary>
        public const string FilterNamedRange = "_FilterDatabase";

        /// <summary>
        /// Print titles data range name
        /// </summary>
        public const string PrintTitlesNamedRange = "Print_Titles";

        /// <summary>
        /// Bottom aggregate formula pattern
        /// </summary>
        public const string BottomAggregateFormulaPattern = "SUBTOTAL({0},R[-{{$__rows}}]C:R[-1]C)";

        /// <summary>
        /// Table range pattern
        /// </summary>
        public const string PrintTitlesRangePattern = "R{$__PrintTitlesTopRow}:R{$__PrintTitlesBottomRow}";

        /// <summary>
        /// Table range pattern
        /// </summary>
        public const string TableRangePattern = "R{$__TableRange_Y1}C{$__TableRange_X1}:R{$__TableRange_Y2}C{$__TableRange_X2}";

        /// <summary>
        /// Top aggregate formula pattern
        /// </summary>
        public const string TopAggregateFormulaPattern = "SUBTOTAL({0},R[2]C:R[{{$__EndTopAggregate}}]C)";
    }
}
