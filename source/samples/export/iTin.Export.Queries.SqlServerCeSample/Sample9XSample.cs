using System;

using iTin.Export.Inputs;
using iTin.Export.Model;

namespace iTin.Export.Queries.SqlServerCe.Sample
{
    public class Sample9XSample
    {
        private const string EpplusHeader          = " 9 - EPPlus samples";
        private const string OneStepText           = " a. Read data from file";
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

        public static void RunSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(new string('-', 52));

            Console.WriteLine(OneStepText);
            var inputUri = new Uri(Properties.Settings.Default.ProductXmlInput, UriKind.Relative);
            var export = new XmlInput(inputUri);

            Console.Write(TwoStepText);
            Console.WriteLine();
            Console.WriteLine(ThreeStepText);

            Console.WriteLine(FourStepText);
            Console.WriteLine(FirstSampleStepText);
            var model = CreateSample90Model();
            export.Export(ExportSettings.CreateFromModel(model, "sample90"));

            Console.WriteLine(FiveStepText);
            Console.WriteLine(FirstSampleStepText);
            var sample90FileConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90FileConfiguration, "sample90"));

            Console.WriteLine(SecondSampleStepText);
            var sample90ChartConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90ChartConfiguration, "sample90-chart"));

            Console.WriteLine(ThirdSampleStepText);
            var sample90BannerConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90BannerConfiguration, "sample90-banner"));

            Console.WriteLine(FourthSampleStepText);
            var sample90HeaderInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90HeaderInfoConfiguration, "sample90-headerinfo"));

            Console.WriteLine(FifthSampleStepText);
            var sample90HeaderBuiltInFunctionsInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90HeaderBuiltInFunctionsInfoConfiguration, "sample90-headerinfo-built-in-functions"));

            Console.WriteLine(SixthSampleStepText);
            var sample90HeaderCustomFunctionsInfoConfiguration = new Uri(Properties.Settings.Default.Sample90, UriKind.Relative);
            export.Export(ExportSettings.ImportFrom(sample90HeaderCustomFunctionsInfoConfiguration, "sample90-headerinfo-custom-functions"));
        }

        private static ExportsModel CreateSample90Model()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts = { new HostModel {Key = "xlsx"} },
                        Images = { new ImageModel { Key = "banner", Path = @"~\resources\images\banner-careers.png", Effects = {new OpacityEffectModel {Percent = 70} } } },
                        Styles =
                        {
                            new StyleModel { Name = "HeaderStyle", Content = { Color ="Navy"}, Font = new FontModel {Color = "White", Bold = YesNo.Yes} },
                            new StyleModel { Name = "ValueTextStyle" },
                            new StyleModel { Name = "NumericStandardStyle", Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() } },
                            new StyleModel { Name = "NumericStandardWithBorderStyle", Inherits = "NumericStandardStyle", Borders = { new BorderModel { Color = "Black", Position = KnownBorderPosition.Top, Weight = KnownWidthLineStyle.Thin, LineStyle = KnownBorderLineStyle.Continuous } }, Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() } },
                            new StyleModel { Name = "NumericWithoutDecimalsStyle", Inherits = "NumericStandardStyle", Content = { DataType = new NumberDataTypeModel { Decimals = 0 } } },
                            new StyleModel { Name = "NumericWithoutDecimalsWithBorderStyle", Inherits = "NumericStandardWithBorderStyle", Content = { DataType = new NumberDataTypeModel { Decimals = 0 } } },
                            new StyleModel { Name = "EmptyLineStyle", Content = { Color = "#BD4F46", Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Center }, DataType= new TextDataTypeModel()}, Font = {Name = "Segoe UI", Color = "White" } },
                            new StyleModel { Name = "TitleLineStyle", Inherits="EmptyLineStyle", Content = { Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left } }, Font = new FontModel { Size = 18, Bold = YesNo.Yes } },
                            new StyleModel { Name = "FirstLineStyle", Content = {Color = "#BD4F46", DataType = new DatetimeDataTypeModel { Format = KnownDatetimeFormat.ShortDatePattern, Locale= KnownCulture.enUS } }, Font = { Name = "Segoe UI", Color = "White" } }
                        },
                        Lines =
                        {
                            new TextLineModel
                            {
                                Key = "ReportTitleLine",
                                Style = "ReportTitleStyle",
                                Items = {new TextModel {Merge = 13, Value = "Invoice report from code"}}
                            },
                            new TextLineModel
                            {
                                Key = "ReportInformationLine01",
                                Style = "ReportInformationLineStyle",
                                Items =
                                {
                                    new TextModel {Value = "Fecha desde:"},
                                    new TextModel
                                    {
                                        Merge = 7,
                                        Style = "ReportInformationLine01Style",
                                        Value = "{Bind:GetCurrentDatetime}"
                                    }
                                }
                            },
                            new TextLineModel
                            {
                                Key = "ReportInformationLine02",
                                Style = "ReportInformationLineStyle",
                                Items =
                                {
                                    new TextModel {Value = "Fecha hasta:"},
                                    new TextModel
                                    {
                                        Merge = 7,
                                        Style = "ReportInformationLine02Style",
                                        Value = "{Bind:Common.GetCurrentDatetime}"
                                    }
                                }
                            }
                        },
                        Groups =
                        {
                            new GroupModel
                            {
                                Name = "CustomerName",
                                Fields =
                                {
                                    new GroupItemModel {Name = "CUSTOMERFIRSTNAME", Separator = ", "},
                                    new GroupItemModel {Name = "CUSTOMERLASTNAME"}
                                }
                            }
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "xmlinput-xlsx",
                            Current = YesNo.Yes,
                            Description = "Invoice query sample",
                            BlockLines =
                            {
                                new BlockLineModel
                                {
                                    Key = "Block01",
                                    Location = {Mode = new CoordenatesModel {Coordenates = new[] {1, 3}}},
                                    Items =
                                    {
                                        Keys = {"ReportTitleLine", "ReportInformationLine01", "ReportInformationLine02"}
                                    }
                                }
                            },
                            Table = new TableModel
                            {
                                Alias = "Invoice query sample - ArrayList",
                                Host = "xlsx",
                                Name = "Invoice",
                                AutoFilter = YesNo.Yes,
                                ShowGridLines = YesNo.No,
                                AutoFitColumns = YesNo.Yes,
                                Output = {Path = @"~\output\xml", File = "InvoiceQuerySampleFromCode"},
                                Location = {Mode = new CoordenatesModel {Coordenates = new[] {1, 7}}},
                                Logo =
                                {
                                    Image = {Key = "banner"},
                                    Location = {Mode = new CoordenatesModel {Coordenates = new[] {4, 1}}}
                                },
                                Exporter =
                                {
                                    Current = new WriterModel {Name = "XlsxTabularWriter"},
                                    Behaviors = {new DownloadBehaviorModel()}
                                },
                                Headers =
                                {
                                    new ColumnHeaderModel
                                    {
                                        From = "ID",
                                        To = "DATE",
                                        Style = "HeaderStringNoBorderStyle",
                                        Text = "Invoice"
                                    },
                                    new ColumnHeaderModel
                                    {
                                        From = "CustomerName",
                                        To = "CUSTOMEREMAIL",
                                        Style = "HeaderStringNoBorderStyle",
                                        Text = "Customer information"
                                    },
                                    new ColumnHeaderModel
                                    {
                                        From = "BILLINGADDRESS",
                                        To = "TOTAL",
                                        Style = "HeaderStringNoBorderStyle",
                                        Text = "Bill information"
                                    }
                                },
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueNumericStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Count,
                                            Style = "HeaderNumericStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "DATE",
                                        Alias = "Title",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueDatetimeStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new GroupFieldModel
                                    {
                                        Name = "CustomerName",
                                        Alias = "Customer",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "CUSTOMERPHONE",
                                        Alias = "Phone",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "CUSTOMEREMAIL",
                                        Alias = "Email",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "BILLINGADDRESS",
                                        Alias = "Address",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "BILLINGCITY",
                                        Alias = "City",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "BILLINGSTATE",
                                        Alias = "State",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "BILLINGCOUNTRY",
                                        Alias = "Country",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "BILLINGPOSTALCODE",
                                        Alias = "Postal Code",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueStringStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Text,
                                            Style = "HeaderStringNoBorderStyle",
                                            Text = string.Empty,
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "TOTAL",
                                        Alias = "Total",
                                        Header = {Style = "HeaderStringStyle"},
                                        Value = {Style = "ValueDecimalStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Top,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "HeaderDecimalStyle",
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

//private static ExportsModel CreateSample90Model()
//{
//    return
//        new ExportsModel
//        {
//            References =
//                {
//                            new ReferenceModel { Path = @"~\resources\functions\", Assembly = "iTin.Export.Queries.SqlServerCe.Functions" }
//                },
//            Resources =
//                {
//                            Hosts =
//                            {
//                                new HostModel { Key = "xlsx", Document = { Size = KnownDocumentSize.A3, Orientation = KnownDocumentOrientation.Landscape, Margins = { Bottom = 10, Top = 10, Right = 10, Left = 10, Units = KnownUnit.Millimeters }}}
//                            },
//                            Images =
//                            {
//                                new ImageModel { Key = "banner", Path = @"~\resources\images\banner-careers.png", Effects = { new OpacityEffectModel { Percent = 90 } } }
//                            },
//                            Styles =
//                            {
//                                new StyleModel { Name = "ReportTitleStyle", Content = { Alignment = { Horizontal = KnownHorizontalAlignment.Center } }, Font = new FontModel { Name = "Calibri", Size = 18, Bold = YesNo.Yes }},
//                                new StyleModel { Name = "ReportInformationLineStyle", Font = new FontModel { Name = "Calibri", Bold = YesNo.Yes }},
//                                new StyleModel { Name = "ReportInformationLine01Style", Content = { DataType = new DatetimeDataTypeModel { Locale = KnownCulture.enUS, Format = KnownDatetimeFormat.LongDatePattern }}, Font = { Name = "Calibri"}},
//                                new StyleModel { Name = "ReportInformationLine02Style", Content = { DataType = new DatetimeDataTypeModel { Locale = KnownCulture.enUS, Format = KnownDatetimeFormat.LongDatePattern }}, Font = { Name = "Calibri"}},
//                                new StyleModel { Name = "HeaderDecimalStyle", Content = { Color = "#ED7D31", Alignment = { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel { Separator = YesNo.Yes }}, Font = new FontModel { Name = "Calibri", Size = 12, Color = "White", Bold = YesNo.Yes }},
//                                new StyleModel { Name = "HeaderStringStyle", Content = { Color = "#ED7D31" }, Font = new FontModel { Name = "Calibri", Size = 11, Color = "White", Bold = YesNo.Yes }, Borders = { new BorderModel { Color = "Black", Position = KnownBorderPosition.Bottom, Weight = KnownWidthLineStyle.Medium, LineStyle = KnownBorderLineStyle.Continuous }}},
//                                new StyleModel { Name = "HeaderStringNoBorderStyle", Content = { Color = "#ED7D31" }, Font = { Name = "Calibri", Color = "White", Bold = YesNo.Yes, Size = 12}},
//                                new StyleModel { Name = "HeaderNumericStyle", Content = { Color = "#ED7D31", Alignment = { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel { Decimals = 0 }}, Font = new FontModel { Name = "Calibri", Size = 12, Color = "White", Bold = YesNo.Yes }},
//                                new StyleModel { Name = "ValueDatetimeStyle", Content = { Color = "#FCE4D6", DataType = new DatetimeDataTypeModel() }, Font = { Name = "Calibri" }},
//                                new StyleModel { Name = "ValueDecimalStyle", Content = { Color = "#FCE4D6", Alignment = { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel { Separator = YesNo.Yes }}, Font = new FontModel { Name = "Calibri" }},
//                                new StyleModel { Name = "ValueNumericStyle", Content = { Color = "#ED7D31", Alignment = { Horizontal = KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel { Decimals = 0 }}, Font = new FontModel { Name = "Calibri", Color = "White" }},
//                                new StyleModel { Name = "ValueStringStyle", Content = { Color = "#FCE4D6" }, Font = { Name = "Calibri" }},
//                            },
//                            Lines =
//                            {
//                                new TextLineModel { Key = "ReportTitleLine", Style = "ReportTitleStyle", Items = { new TextModel { Merge = 13, Value = "Invoice report from code" } } },
//                                new TextLineModel { Key = "ReportInformationLine01", Style = "ReportInformationLineStyle", Items = { new TextModel { Value = "Fecha desde:" }, new TextModel { Merge = 7, Style = "ReportInformationLine01Style", Value = "{Bind:GetCurrentDatetime}" }}},
//                                new TextLineModel { Key = "ReportInformationLine02", Style = "ReportInformationLineStyle", Items = { new TextModel { Value = "Fecha hasta:" }, new TextModel { Merge = 7, Style = "ReportInformationLine02Style", Value = "{Bind:Common.GetCurrentDatetime}" }}}
//                            },
//                            Groups =
//                            {
//                                new GroupModel { Name = "CustomerName", Fields = { new GroupItemModel { Name = "CUSTOMERFIRSTNAME", Separator =", "}, new GroupItemModel { Name = "CUSTOMERLASTNAME"}}}
//                            }
//                },
//            Items =
//                {
//                            new ExportModel
//                                {
//                                    Name = "xmlinput-xlsx",
//                                    Current = YesNo.Yes,
//                                    Description = "Invoice query sample",
//                                    BlockLines =
//                                    {
//                                        new BlockLineModel { Key = "Block01", Location = { Mode = new CoordenatesModel { Coordenates = new[] {1, 3} }}, Items = { Keys = { "ReportTitleLine", "ReportInformationLine01", "ReportInformationLine02" }}}
//                                    },
//                                    Table = new TableModel
//                                    {
//                                        Alias = "Invoice query sample - ArrayList",
//                                        Host = "xlsx",
//                                        Name = "Invoice",
//                                        AutoFilter = YesNo.Yes,
//                                        ShowGridLines = YesNo.No,
//                                        AutoFitColumns = YesNo.Yes,
//                                        Output = { Path = @"~\output\xml", File = "InvoiceQuerySampleFromCode" },
//                                        Location = { Mode = new CoordenatesModel { Coordenates = new[] {1, 7} }},
//                                        Logo = { Image = { Key = "banner" }, Location = { Mode = new CoordenatesModel { Coordenates = new[] {4, 1} }}},
//                                        Exporter = { Current = new WriterModel { Name = "XlsxTabularWriter" }, Behaviors = { new DownloadBehaviorModel() }},
//                                        Headers =
//                                        {
//                                            new ColumnHeaderModel {From = "ID", To = "DATE", Style = "HeaderStringNoBorderStyle", Text = "Invoice"},
//                                            new ColumnHeaderModel {From = "CustomerName", To = "CUSTOMEREMAIL", Style = "HeaderStringNoBorderStyle", Text = "Customer information"},
//                                            new ColumnHeaderModel {From = "BILLINGADDRESS", To = "TOTAL", Style = "HeaderStringNoBorderStyle", Text = "Bill information"}
//                                        },
//                                        Fields =
//                                        {
//                                            new DataFieldModel { Name = "ID", Alias = "Id", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueNumericStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Count, Style = "HeaderNumericStyle", Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "DATE", Alias = "Title", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueDatetimeStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new GroupFieldModel { Name = "CustomerName", Alias = "Customer", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "CUSTOMERPHONE", Alias = "Phone", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "CUSTOMEREMAIL", Alias = "Email", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "BILLINGADDRESS", Alias = "Address", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "BILLINGCITY", Alias = "City", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "BILLINGSTATE", Alias = "State", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "BILLINGCOUNTRY", Alias = "Country", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "BILLINGPOSTALCODE", Alias = "Postal Code", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueStringStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Text, Style = "HeaderStringNoBorderStyle", Text = string.Empty, Show = YesNo.Yes }},
//                                            new DataFieldModel { Name = "TOTAL", Alias = "Total", Header = { Style = "HeaderStringStyle" }, Value = { Style = "ValueDecimalStyle" }, Aggregate = { Location = KnownAggregateLocation.Top, AggregateType = KnownAggregateType.Sum, Style = "HeaderDecimalStyle", Show = YesNo.Yes }}
//                                        }
//                                    }
//                                }
//                }
//        };
//}
