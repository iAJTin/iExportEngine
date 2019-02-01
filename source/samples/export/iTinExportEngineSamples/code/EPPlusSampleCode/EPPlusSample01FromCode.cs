
namespace iTinExportEngineSamples.EPPlusSamples
{
    using System;

    using iTin.Export;
    using iTin.Export.Inputs;
    using iTin.Export.Model;

    using Properties;    

    public class EPPlusSample01FromCode
    {
        private const string EpplusHeader = " · Running Sample 1 (From Code)";
        private const string FirstSampleStepText = "  - Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List.";

        /// <summary>
        /// Runs the sample.
        /// </summary>
        public static void RunFromCodeSample()
        {
            Console.WriteLine(EpplusHeader);
            Console.WriteLine(FirstSampleStepText);

            var inputDataFile = new Uri(Settings.Default.InventoryXmlInput, UriKind.Relative);
            var input = new XmlInput(inputDataFile);

            var configurationModel = CreateModel();
            input.Export(ExportSettings.CreateFromModels(configurationModel, "Sample01"));
        }

        private static ExportsModel CreateModel()
        {
            return
                new ExportsModel
                {
                    Resources =
                    {
                        Hosts =
                        {
                            new HostModel
                            {
                                Key = "xlsx",
                                Document =
                                {
                                    View = KnownDocumentView.Design,
                                    Header = { Sections = {{ new HeaderFooterSectionModel {Alignment = KnownHeaderFooterAlignment.Center, Text = "Inventory"} }}}
                                }
                            }
                        },
                        Styles =
                        {
                            new StyleModel
                            {
                                Name = "HeaderStyle",
                                Content = {Color = "#00008B", Alignment = { Horizontal= KnownHorizontalAlignment.Left }, DataType = new TextDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Color = "White", Bold = YesNo.Yes}
                            },
                            new StyleModel
                            {
                                Name = "IdValueStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Left }, DataType = new NumberDataTypeModel {Decimals = 0} },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f }
                            },
                            new StyleModel
                            {
                                Name = "IdAggregateStyle",
                                Borders = { {new BorderModel { Position = KnownBorderPosition.Top, Color = "Black", LineStyle = KnownBorderLineStyle.Continuous} }},
                                Content = { DataType = new TextDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "ProductValueStyle",
                                Content = { DataType = new TextDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Borders = { {new BorderModel { Position = KnownBorderPosition.Top, Color = "Black", LineStyle = KnownBorderLineStyle.Continuous} }},
                                Name = "ProductAggregateStyle",
                                Content = { DataType = new TextDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f }
                            },
                            new StyleModel
                            {
                                Name = "QuantityValueStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel {Decimals = 0, Separator = YesNo.Yes} },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f }
                            },
                            new StyleModel
                            {
                                Borders = { {new BorderModel { Position = KnownBorderPosition.Top, Color = "Black", LineStyle = KnownBorderLineStyle.Continuous} }},
                                Name = "QuantityAggregateStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel {Decimals = 0, Separator = YesNo.Yes} },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "PriceValueStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f }
                            },
                            new StyleModel
                            {
                                Borders = { {new BorderModel { Position = KnownBorderPosition.Top, Color = "Black", LineStyle = KnownBorderLineStyle.Continuous} }},
                                Name = "PriceAggregateStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Bold = YesNo.Yes }
                            },
                            new StyleModel
                            {
                                Name = "ValueValueStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() }
                            },
                            new StyleModel
                            {
                                Borders = { {new BorderModel { Position = KnownBorderPosition.Top, Color = "Black", LineStyle = KnownBorderLineStyle.Continuous} }},
                                Name = "ValueAggregateStyle",
                                Content = {Alignment = { Horizontal= KnownHorizontalAlignment.Right }, DataType = new NumberDataTypeModel() },
                                Font = new FontModel { Name = "Calibri", Size = 11.0f, Bold = YesNo.Yes }
                            }
                        }
                    },
                    Items =
                    {
                        new ExportModel
                        {
                            Name = "Sample01",
                            Current = YesNo.Yes,
                            Description = "EPPlus - Sample 1",
                            Table = new TableModel
                            {
                                Host = "xlsx",
                                Name = "Inventory",
                                AutoFilter = YesNo.Yes,
                                AutoFitColumns = YesNo.Yes,
                                Alias = "Inventory",
                                Exporter = {Current = new WriterModel {Name = "XlsxTabularWriter"}},
                                Output = {Path = @"~\output\EPPlusSamples\", File = "sample01-from-code"},
                                Fields =
                                {
                                    new DataFieldModel
                                    {
                                        Name = "ID",
                                        Alias = "Id",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "IdValueStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "IdAggregateStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRODUCT",
                                        Alias = "Product",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ProductValueStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            Style = "ProductAggregateStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "QUANTITY",
                                        Alias = "Quantity",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "QuantityValueStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "QuantityAggregateStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "PRICE",
                                        Alias = "Price",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "PriceValueStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "PriceAggregateStyle",
                                            Show = YesNo.Yes
                                        }
                                    },
                                    new DataFieldModel
                                    {
                                        Name = "VALUE",
                                        Alias = "Value",
                                        Header = {Style = "HeaderStyle"},
                                        Value = {Style = "ValueValueStyle"},
                                        Aggregate =
                                        {
                                            Location = KnownAggregateLocation.Bottom,
                                            AggregateType = KnownAggregateType.Sum,
                                            Style = "ValueAggregateStyle",
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
