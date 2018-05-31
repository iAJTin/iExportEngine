
namespace iTin.Export.Model
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Specifies known chart types.
    /// </summary>
    [Serializable]
    [GeneratedCode("System.Xml", "4.0.30319.18034")]
    public enum KnownChartType
    {
        /// <summary>
        /// The bars
        /// </summary>
        Bars,

        /// <summary>
        /// The bars
        /// </summary>
        Bars3D,

        /// <summary>
        /// The bars
        /// </summary>
        Columns,

        /// <summary>
        /// The XY scatter
        /// </summary>
        XYScatter,

        /// <summary>
        /// The radar
        /// </summary>
        Radar,

        /// <summary>
        /// The doughnut
        /// </summary>
        Doughnut,

        /// <summary>
        /// The pie 3D
        /// </summary>
        Pie3D,

        /// <summary>
        /// The line 3D
        /// </summary>
        Line3D,

        /// <summary>
        /// The bars
        /// </summary>
        Column3D,

        /// <summary>
        /// The bars
        /// </summary>
        Area3D,

        /// <summary>
        /// The bars
        /// </summary>
        Area,

        /// <summary>
        /// The line
        /// </summary>
        Line,

        /// <summary>
        /// The pie
        /// </summary>
        Pie,

        /// <summary>
        /// The bubble
        /// </summary>
        Bubble,

        /// <summary>
        /// The column clustered
        /// </summary>
        ColumnClustered,

        /// <summary>
        /// The column stacked
        /// </summary>
        ColumnStacked,

        /// <summary>
        /// The column stacked100
        /// </summary>
        ColumnStacked100,

        /// <summary>
        /// The column clustered3 D
        /// </summary>
        ColumnClustered3D,

        /// <summary>
        /// The column stacked3 D
        /// </summary>
        ColumnStacked3D,

        /// <summary>
        /// The column stacked1003 D
        /// </summary>
        ColumnStacked1003D,

        /// <summary>
        /// The bar clustered
        /// </summary>
        BarClustered,

        /// <summary>
        /// The bar stacked
        /// </summary>
        BarStacked,

        /// <summary>
        /// The bar stacked100
        /// </summary>
        BarStacked100,

        /// <summary>
        /// The bar clustered3 D
        /// </summary>
        BarClustered3D,

        /// <summary>
        /// The bar stacked3 D
        /// </summary>
        BarStacked3D,

        /// <summary>
        /// The bar stacked1003 D
        /// </summary>
        BarStacked1003D,

        /// <summary>
        /// The line stacked
        /// </summary>
        LineStacked,

        /// <summary>
        /// The line stacked100
        /// </summary>
        LineStacked100,

        /// <summary>
        /// The line markers
        /// </summary>
        LineMarkers,

        /// <summary>
        /// The line markers stacked
        /// </summary>
        LineMarkersStacked,

        /// <summary>
        /// The line markers stacked100
        /// </summary>
        LineMarkersStacked100,

        /// <summary>
        /// The pie of pie
        /// </summary>
        PieOfPie,

        /// <summary>
        /// The pie exploded
        /// </summary>
        PieExploded,

        /// <summary>
        /// The pie exploded 3D
        /// </summary>
        PieExploded3D,

        /// <summary>
        /// The bar of pie
        /// </summary>
        BarOfPie,

        /// <summary>
        /// The XY scatter smooth
        /// </summary>
        XYScatterSmooth,

        /// <summary>
        /// The XY scatter smooth no markers
        /// </summary>
        XYScatterSmoothNoMarkers,

        /// <summary>
        /// The XY scatter lines
        /// </summary>
        XYScatterLines,

        /// <summary>
        /// The XY scatter lines no markers
        /// </summary>
        XYScatterLinesNoMarkers,
        
        /// <summary>
        /// The area stacked
        /// </summary>
        AreaStacked,
        
        /// <summary>
        /// The area stacked100
        /// </summary>
        AreaStacked100,
        
        /// <summary>
        /// The area stacked3 D
        /// </summary>
        AreaStacked3D,
        
        /// <summary>
        /// The area stacked1003 D
        /// </summary>
        AreaStacked1003D,
        
        /// <summary>
        /// The doughnut exploded
        /// </summary>
        DoughnutExploded,
        
        /// <summary>
        /// The radar markers
        /// </summary>
        RadarMarkers,

        /// <summary>
        /// The radar filled
        /// </summary>
        RadarFilled,

        /// <summary>
        /// The surface
        /// </summary>
        Surface,

        /// <summary>
        /// The surface wireframe
        /// </summary>
        SurfaceWireframe,

        /// <summary>
        /// The surface top view
        /// </summary>
        SurfaceTopView,
        
        /// <summary>
        /// The surface top view wireframe
        /// </summary>
        SurfaceTopViewWireframe,
        
        /// <summary>
        /// The bubble3 D effect
        /// </summary>
        Bubble3DEffect,
        
        /// <summary>
        /// The stock HLC
        /// </summary>
        StockHLC,
        
        /// <summary>
        /// The stock OHLC
        /// </summary>
        StockOHLC,
        
        /// <summary>
        /// The stock VHLC
        /// </summary>
        StockVHLC,
        
        /// <summary>
        /// The stock VOHLC
        /// </summary>
        StockVOHLC,
        
        /// <summary>
        /// The cylinder col clustered
        /// </summary>
        CylinderColClustered,
        
        /// <summary>
        /// The cylinder col stacked
        /// </summary>
        CylinderColStacked,
        
        /// <summary>
        /// The cylinder col stacked100
        /// </summary>
        CylinderColStacked100,
        
        /// <summary>
        /// The cylinder bar clustered
        /// </summary>
        CylinderBarClustered,
        
        /// <summary>
        /// The cylinder bar stacked
        /// </summary>
        CylinderBarStacked,
        
        /// <summary>
        /// The cylinder bar stacked100
        /// </summary>
        CylinderBarStacked100,
        
        /// <summary>
        /// The cylinder col
        /// </summary>
        CylinderCol,
        
        /// <summary>
        /// The cone col clustered
        /// </summary>
        ConeColClustered,
        
        /// <summary>
        /// The cone col stacked
        /// </summary>
        ConeColStacked,
        
        /// <summary>
        /// The cone col stacked100
        /// </summary>
        ConeColStacked100,
        
        /// <summary>
        /// The cone bar clustered
        /// </summary>
        ConeBarClustered,

        /// <summary>
        /// The cone bar stacked
        /// </summary>
        ConeBarStacked,
        
        /// <summary>
        /// The cone bar stacked100
        /// </summary>
        ConeBarStacked100,
        
        /// <summary>
        /// The cone col
        /// </summary>
        ConeCol,
        
        /// <summary>
        /// The pyramid col clustered
        /// </summary>
        PyramidColClustered,

        /// <summary>
        /// The pyramid col stacked
        /// </summary>
        PyramidColStacked,

        /// <summary>
        /// The pyramid col stacked100
        /// </summary>
        PyramidColStacked100,

        /// <summary>
        /// The pyramid bar clustered
        /// </summary>
        PyramidBarClustered,

        /// <summary>
        /// The pyramid bar stacked
        /// </summary>
        PyramidBarStacked,

        /// <summary>
        /// The pyramid bar stacked100
        /// </summary>
        PyramidBarStacked100,

        /// <summary>
        /// The pyramid col
        /// </summary>
        PyramidCol
    }
}
