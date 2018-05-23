using System;

using iTin.Export.Inputs;
using iTin.Export.Model;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    public class Sample9XSample
    {
        private const string EpplusHeader          = " 9 - EPPlus samples";
        private const string OneStepText           = " a. Read data from xml file";
        private const string TwoStepText           = " b. Export data";
        private const string ThreeStepText         = "   . MS Excel (xlsx)";
        private const string FourStepText          = "     - From code";
        private const string FiveStepText          = "     - From configuration file";
        private const string FirstSampleStepText   = "         -> Some data...                   -> [sample90.xlsx] <-";
        private const string SecondSampleStepText  = "         -> ... with chart ...             -> [sample90-chart.xlsx] <-";
        private const string ThirdSampleStepText   = "         -> ... and banner ...             -> [sample90-banner.xlsx] <-";
        private const string FourthSampleStepText  = "         -> ... and resume info ...        -> [sample90-headerinfo.xlsx] <-";
        private const string FifthSampleStepText   = "         -> ... and built-in functions ... -> [sample90-headerinfo-built-in-functions.xlsx] <-";
        private const string SixthSampleStepText   = "         -> ... and custom functions       -> [sample90-headerinfo-custom-functions.xlsx] <-";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(new string('-', 52));

            Console.WriteLine(OneStepText);
            var inputUri = new Uri(Properties.Settings.Default.SEKRatesXmlInput, UriKind.Relative);
            var export = new XmlInput(inputUri);

            Console.Write(TwoStepText);
            Console.WriteLine();
            Console.WriteLine(ThreeStepText);

            //Console.WriteLine(FourStepText);
            //Console.WriteLine(FirstSampleStepText);
            ////var sample90ModelConfiguration = CreateSample90Model();
            ////export.Export(ExportSettings.CreateFromModel(sample90ModelConfiguration, "sample90"));

            //Console.WriteLine(SecondSampleStepText);
            //var sample90ChartModelConfiguration = CreateChartSample90Model();
            ////export.Export(ExportSettings.CreateFromModel(sample90ChartModelConfiguration, "sample90-chart"));

            //Console.WriteLine(ThirdSampleStepText);
            //var sample90BannerModelConfiguration = CreateBannerSample90Model();
            //export.Export(ExportSettings.CreateFromModels(sample90BannerModelConfiguration, "sample90-banner"));

            //Console.WriteLine(FourthSampleStepText);
            //var sample90HeaderInfoModelConfiguration = CreateHeaderInfoSample90Model();
            //export.Export(ExportSettings.CreateFromModels(sample90HeaderInfoModelConfiguration, "sample90-headerinfo"));

            //Console.WriteLine(FifthSampleStepText);
            //var sample90HeaderInfoBuiltInFunctionsModelConfiguration = CreateHeaderInfoBuiltInFunctionsSample90Model();
            //export.Export(ExportSettings.CreateFromModels(sample90HeaderInfoBuiltInFunctionsModelConfiguration, "sample90-headerinfo-built-in-functions"));

            //Console.WriteLine(SixthSampleStepText);
            //var sample90HeaderInfoCustomFunctionsModelConfiguration = CreateHeaderInfoCustomFunctionsSample90Model();
            //export.Export(ExportSettings.CreateFromModels(sample90HeaderInfoCustomFunctionsModelConfiguration, "sample90-headerinfo-custom-functions"));


            Console.WriteLine(FiveStepText);
            Console.WriteLine(FirstSampleStepText);
            var sample90FileConfiguration = new Uri(Properties.Settings.Default.Sample16, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90FileConfiguration, "sample16"));

            //Console.WriteLine(SecondSampleStepText);
            //var sample90ChartConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90ChartConfiguration, "sample90-chart"));

            //Console.WriteLine(ThirdSampleStepText);
            //var sample90BannerConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90BannerConfiguration, "sample90-banner"));

            //Console.WriteLine(FourthSampleStepText);
            //var sample90HeaderInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90HeaderInfoConfiguration, "sample90-headerinfo"));

            //Console.WriteLine(FifthSampleStepText);
            //var sample90HeaderBuiltInFunctionsInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90HeaderBuiltInFunctionsInfoConfiguration, "sample90-headerinfo-built-in-functions"));

            //Console.WriteLine(SixthSampleStepText);
            //var sample90HeaderCustomFunctionsInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            //export.Export(ExportSettings.ImportFrom(sample90HeaderCustomFunctionsInfoConfiguration, "sample90-headerinfo-custom-functions"));
        }

        private static ExportsModel CreateSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            }
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90",
                            Current = YesNo.Yes,
                            Description = "EPPlus - Some data",
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - Some data",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-file"},
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
        }

        private static ExportsModel CreateChartSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            }
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90-chart",
                            Description = "EPPlus - Some data and a pie chart",
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - Some data and a pie chart",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-file-chart"},
                                Charts =
                                {
                                    new ChartModel
                                    {
                                        Size = new [] {640, 300},
                                        Location = { Mode = new CoordenatesModel { Coordenates = new[] {6, 1} }},
                                        Title =
                                        {
                                            Text = "Total",
                                            Font = new FontModel {Size = 12, Bold = YesNo.Yes}
                                        },
                                        Legend =
                                        {
                                            Show = YesNo.Yes,
                                            Font = new FontModel {Size = 12, Bold = YesNo.Yes}
                                        },
                                        Plots =
                                        {
                                            new ChartPlotModel
                                            {
                                                Name ="plot1",
                                                Series =
                                                {
                                                    new ChartSerieModel
                                                    {
                                                        Field ="VALUE",
                                                        Axis ="PRODUCT",
                                                        Name ="ProductSerie",
                                                        ChartType = KnownChartType.Pie3D
                                                    }
                                                }
                                            }
                                        }
                                    }
                                },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },                               
                                }
                            }
                        }
                    }
                };
        }

        private static ExportsModel CreateBannerSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Images =
                        {
                            new ImageModel
                            {
                                Key = "banner",
                                Path = @"~\resources\images\banner-careers.png",
                                Effects = { new OpacityEffectModel { Percent = 70f } },
                            },
                        },
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            }
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90-banner",
                            Current = YesNo.Yes,
                            Description = "EPPlus - Some data with banner",
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - Some data",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-file-banner"},
                                Location = { Mode= new CoordenatesModel { Coordenates = new[] { 4, 3} } },
                                Logo =
                                {
                                    Image = { Key = "banner" },
                                    Location = { Mode= new CoordenatesModel() }
                                },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
        }

        private static ExportsModel CreateHeaderInfoSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            },
                            new StyleModel
                            {
                                Name = "EmptyLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Center },
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                            new StyleModel
                            {
                                Name = "TitleLineStyle",
                                Inherits = "EmptyLineStyle",
                                Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left } },
                                Font = new FontModel { Size = 18f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "FirstLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left },
                                    DataType = new DatetimeDataTypeModel { Format=KnownDatetimeFormat.ShortDatePattern, Locale=KnownCulture.enUS }
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                        },
                        Lines =
                        {
                            new EmptyLineModel
                            {
                                Key = "ReportEmptyLine",
                                Style = "EmptyLineStyle",
                                Merge = 7
                            },
                            new TextLineModel
                            {
                                Key = "ReportTitleLine",
                                Style = "TitleLineStyle",
                                Items = { new TextModel { Merge = 7, Value = "EPPlus demo samples" } }
                            },
                            new TextLineModel
                            {
                                Key = "ReportFirstLine",
                                Style = "FirstLineStyle",
                                Items =
                                {
                                    new TextModel { Value = "Date:" },
                                    new TextModel { Merge = 6, Value = "2017-01-01" }
                                }
                            },
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90-headerinfo",
                            Current = YesNo.Yes,
                            Description = "EPPlus - Some data with header",
                            BlockLines =
                            {
                                new BlockLineModel
                                {
                                    Key = "Block01",
                                    Location = { Mode= new CoordenatesModel() },
                                    Items = { Keys = { "ReportTitleLine", "ReportEmptyLine", "ReportFirstLine" } }
                                }
                            },
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - Some data with header",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-file-headerinfo"},
                                Location = { Mode= new CoordenatesModel { Coordenates = new[] { 2, 5} } },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
        }

        private static ExportsModel CreateHeaderInfoBuiltInFunctionsSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            },
                            new StyleModel
                            {
                                Name = "EmptyLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Center },
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                            new StyleModel
                            {
                                Name = "TitleLineStyle",
                                Inherits = "EmptyLineStyle",
                                Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left } },
                                Font = new FontModel { Size = 18f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "FirstLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left },
                                    DataType = new DatetimeDataTypeModel { Format=KnownDatetimeFormat.ShortDatePattern, Locale=KnownCulture.enUS }
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                        },
                        Lines =
                        {
                            new EmptyLineModel
                            {
                                Key = "ReportEmptyLine",
                                Style = "EmptyLineStyle",
                                Merge = 7
                            },
                            new TextLineModel
                            {
                                Key = "ReportTitleLine",
                                Style = "TitleLineStyle",
                                Items = { new TextModel { Merge = 7, Value = "EPPlus demo samples" } }
                            },
                            new TextLineModel
                            {
                                Key = "ReportFirstLineBuiltInFunctions",
                                Style = "FirstLineStyle",
                                Items =
                                {
                                    new TextModel { Value = "Date:" },
                                    new TextModel { Merge = 6, Value = "{Bind:GetCurrentDatetime}" }
                                }
                            },
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90-headerinfo-built-in-functions",
                            Current = YesNo.Yes,
                            Description = "EPPlus - Built-in functions",
                            BlockLines =
                            {
                                new BlockLineModel
                                {
                                    Key = "Block01",
                                    Location = { Mode= new CoordenatesModel() },
                                    Items = { Keys = { "ReportTitleLine", "ReportEmptyLine", "ReportFirstLineBuiltInFunctions" } }
                                }
                            },
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - Built-in functions",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-headerinfo-built-in-functions"},
                                Location = { Mode= new CoordenatesModel { Coordenates = new[] { 2, 5} } },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
        }

        private static ExportsModel CreateHeaderInfoCustomFunctionsSample90Model()
        {
            return
                new ExportsModel
                {
                    References =
                    {
                        new ReferenceModel { Path = @"~\Resources\Functions\", Assembly="iTin.Export.Queries.SqlServerCe.Functions" }
                    },
                    Resources =
                    {
                        Hosts = {new HostModel {Key = "xlsx"}},
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "Navy"},
                                Font = new FontModel {Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel {Name = "ValueTextStyle"},
                            new StyleModel
                            {
                                Name = "NumericStandardStyle",
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericStandardWithBorderStyle",
                                Inherits = "NumericStandardStyle",
                                Borders =
                                {
                                    new BorderModel
                                    {
                                        Color = "Black",
                                        Position = KnownBorderPosition.Top,
                                        Weight = KnownWidthLineStyle.Thin,
                                        LineStyle = KnownBorderLineStyle.Continuous
                                    }
                                },
                                Content =
                                {
                                    Alignment = new ContentAlignmentModel {Horizontal = KnownHorizontalAlignment.Right},
                                    DataType = new NumberDataTypeModel()
                                }
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsStyle",
                                Inherits = "NumericStandardStyle",
                                Content = {DataType = new NumberDataTypeModel {Decimals = 0}}
                            },
                            new StyleModel
                            {
                                Name = "NumericWithoutDecimalsWithBorderStyle",
                                Inherits = "NumericStandardWithBorderStyle",
                                Content = { DataType = new NumberDataTypeModel { Decimals = 0 } }
                            },
                            new StyleModel
                            {
                                Name = "EmptyLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Center },
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                            new StyleModel
                            {
                                Name = "TitleLineStyle",
                                Inherits = "EmptyLineStyle",
                                Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left } },
                                Font = new FontModel { Size = 18f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "FirstLineStyle",
                                Content =
                                {
                                    Color = "#BD4F46",
                                    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left },
                                    DataType = new DatetimeDataTypeModel { Format=KnownDatetimeFormat.ShortDatePattern, Locale=KnownCulture.enUS }
                                },
                                Font = new FontModel { Name = "Segoe UI", Color = "White" }
                            },
                        },
                        Lines =
                        {
                            new EmptyLineModel
                            {
                                Key = "ReportEmptyLine",
                                Style = "EmptyLineStyle",
                                Merge = 7
                            },
                            new TextLineModel
                            {
                                Key = "ReportTitleLine",
                                Style = "TitleLineStyle",
                                Items = { new TextModel { Merge = 7, Value = "EPPlus demo samples" } }
                            },
                            new TextLineModel
                            {
                                Key = "ReportFirstLineFromCustomFunctions",
                                Style = "FirstLineStyle",
                                Items =
                                {
                                    new TextModel { Value = "Date:" },
                                    new TextModel { Merge = 6, Value = "{Bind:Common.GetCurrentDatetime}" }
                                }
                            },
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "sample90-headerinfo-custom-functions",
                            Current = YesNo.Yes,
                            Description = "EPPlus - custom functions",
                            BlockLines =
                            {
                                new BlockLineModel
                                {
                                    Key = "Block01",
                                    Location = { Mode= new CoordenatesModel() },
                                    Items = { Keys = { "ReportTitleLine", "ReportEmptyLine", "ReportFirstLineFromCustomFunctions" } }
                                }
                            },
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Product",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "EPPlus - custom functions",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\sample9x\fromcode", File = "sample90-headerinfo-custom-functions"},
                                Location = { Mode= new CoordenatesModel { Coordenates = new[] { 2, 5} } },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueTextStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericWithoutDecimalsStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericWithoutDecimalsWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "NumericStandardStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "NumericStandardWithBorderStyle",
                                            Show = YesNo.Yes
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
        }
    }
}
