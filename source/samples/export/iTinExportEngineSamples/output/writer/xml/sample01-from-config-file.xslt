<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:html="http://www.w3.org/TR/REC-html40" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="urn:schemas-microsoft-com:office:spreadsheet" xmlns:o="urn:schemas-microsoft-com:office:office" xmlns:x="urn:schemas-microsoft-com:office:excel" xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet" xmlns:ms="urn:schemas-microsoft-com:xslt" xmlns:dt="urn:schemas-microsoft-com:datatypes">
  <xsl:output indent="yes" />
  <xsl:template match="/">
    <xsl:processing-instruction name="mso-application">progid="Excel.Sheet"</xsl:processing-instruction>
    <xsl:variable name="__rows" select="count(*/Inventory)" />
    <xsl:variable name="__EndTopAggregate" select="1 + $__rows" />
    <xsl:variable name="__PrintTitlesTopRow" select="1" />
    <xsl:variable name="__PrintTitlesBottomRow" select="1" />
    <xsl:variable name="__TableRange_X1" select="1" />
    <xsl:variable name="__TableRange_Y1" select="1" />
    <xsl:variable name="__TableRange_X2" select="$__TableRange_X1 + 4" />
    <xsl:variable name="__TableRange_Y2" select="$__rows + 2" />
    <Workbook>
      <OfficeDocumentSettings xmlns="urn:schemas-microsoft-com:office:office">
        <AllowPNG />
      </OfficeDocumentSettings>
      <Styles>
        <Style ss:ID="Default" ss:Name="Normal">
          <Alignment ss:Vertical="Bottom" />
          <Borders />
          <Font ss:FontName="Calibri" x:Family="Swiss" ss:Size="11" ss:Color="#000000" />
          <Interior />
          <NumberFormat />
          <Protection />
        </Style>
        <Style ss:ID="HeaderStyle">
          <Alignment ss:Horizontal="Left" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#ffffff" ss:Bold="1" />
          <Interior ss:Color="#00008b" ss:Pattern="Solid" />
          <NumberFormat ss:Format="@" />
          <Protection />
        </Style>
        <Style ss:ID="IdValueStyle">
          <Alignment ss:Horizontal="Left" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="##0;[Black]\-##0" />
          <Protection />
        </Style>
        <Style ss:ID="IdAggregateStyle">
          <Alignment ss:Horizontal="Left" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Top" ss:Color="#000000" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" ss:Bold="1" />
          <Interior />
          <NumberFormat ss:Format="@" />
          <Protection />
        </Style>
        <Style ss:ID="ProductValueStyle">
          <Alignment ss:Horizontal="Left" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" />
          <Interior />
          <NumberFormat ss:Format="@" />
          <Protection />
        </Style>
        <Style ss:ID="ProductAggregateStyle">
          <Alignment ss:Horizontal="Left" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Top" ss:Color="#000000" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" ss:Bold="1" />
          <Interior />
          <NumberFormat ss:Format="@" />
          <Protection />
        </Style>
        <Style ss:ID="QuantityValueStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="#,##0;[Black]\-#,##0" />
          <Protection />
        </Style>
        <Style ss:ID="QuantityAggregateStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Top" ss:Color="#000000" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" ss:Bold="1" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="#,##0;[Black]\-#,##0" />
          <Protection />
        </Style>
        <Style ss:ID="PriceValueStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="##0.00;[Black]\-##0.00" />
          <Protection />
        </Style>
        <Style ss:ID="PriceAggregateStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Top" ss:Color="#000000" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" ss:Bold="1" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="##0.00;[Black]\-##0.00" />
          <Protection />
        </Style>
        <Style ss:ID="ValueValueStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders />
          <Font ss:FontName="Segoe UI" ss:Size="10" ss:Color="#000000" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="##0.00;[Black]\-##0.00" />
          <Protection />
        </Style>
        <Style ss:ID="ValueAggregateStyle">
          <Alignment ss:Horizontal="Right" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Top" ss:Color="#000000" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Calibri" ss:Size="11" ss:Color="#000000" ss:Bold="1" />
          <Interior ss:Color="#ffffff" ss:Pattern="Solid" />
          <NumberFormat ss:Format="##0.00;[Black]\-##0.00" />
          <Protection />
        </Style>
      </Styles>
      <Worksheet ss:Name="Inventory">
        <Names>
          <NamedRange ss:Name="_FilterDatabase" ss:RefersTo="='Inventory'!R{$__TableRange_Y1}C{$__TableRange_X1}:R{$__TableRange_Y2}C{$__TableRange_X2}" ss:Hidden="1" />
          <NamedRange ss:Name="Print_Area" ss:RefersTo="='Inventory'!R{$__TableRange_Y1}C{$__TableRange_X1}:R{$__TableRange_Y2}C{$__TableRange_X2}" />
          <NamedRange ss:Name="Print_Titles" ss:RefersTo="='Inventory'!R{$__PrintTitlesTopRow}:R{$__PrintTitlesBottomRow}" />
        </Names>
        <Table>
          <Column ss:Index="1" ss:Width="25" />
          <Column ss:Index="2" ss:Width="52" />
          <Column ss:Index="3" ss:Width="55" />
          <Column ss:Index="4" ss:Width="39" />
          <Column ss:Index="5" ss:Width="41" />
          <Row ss:Index="1">
            <Cell ss:StyleID="HeaderStyle" ss:Index="1">
              <Data ss:Type="String">ID</Data>
              <NamedCell ss:Name="_FilterDatabase" />
            </Cell>
            <Cell ss:StyleID="HeaderStyle" ss:Index="2">
              <Data ss:Type="String">Product</Data>
              <NamedCell ss:Name="_FilterDatabase" />
            </Cell>
            <Cell ss:StyleID="HeaderStyle" ss:Index="3">
              <Data ss:Type="String">Quantity</Data>
              <NamedCell ss:Name="_FilterDatabase" />
            </Cell>
            <Cell ss:StyleID="HeaderStyle" ss:Index="4">
              <Data ss:Type="String">Price</Data>
              <NamedCell ss:Name="_FilterDatabase" />
            </Cell>
            <Cell ss:StyleID="HeaderStyle" ss:Index="5">
              <Data ss:Type="String">Value</Data>
              <NamedCell ss:Name="_FilterDatabase" />
            </Cell>
          </Row>
          <xsl:for-each select="*/Inventory">
            <Row>
              <xsl:variable name="testValueOfID">
                <xsl:choose>
                  <xsl:when test="string(number(normalize-space(@ID)))='NaN'">0</xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="normalize-space(@ID)" />
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:variable>
              <Cell ss:StyleID="IdValueStyle" ss:Index="1">
                <Data ss:Type="Number">
                  <xsl:value-of select="$testValueOfID" disable-output-escaping="yes" />
                </Data>
                <xsl:if test="string(number(@ID))='NaN'">
                  <Comment ss:Autor="SYNTEC-PC6\fernandogarciavega">
                    <ss:Data xmlns="http://www.w3.org/TR/REC-html40">
                      <Font html:Face="Segoe UI" html:Size="10" html:Color="#000000">
                        <xsl:value-of select="@ID" />
                      </Font>
                    </ss:Data>
                  </Comment>
                </xsl:if>
                <NamedCell ss:Name="_FilterDatabase" />
              </Cell>
              <Cell ss:StyleID="ProductValueStyle" ss:Index="2">
                <Data ss:Type="String">
                  <xsl:value-of select="normalize-space(@PRODUCT)" disable-output-escaping="yes" />
                </Data>
                <NamedCell ss:Name="_FilterDatabase" />
              </Cell>
              <xsl:variable name="testValueOfQUANTITY">
                <xsl:choose>
                  <xsl:when test="string(number(normalize-space(@QUANTITY)))='NaN'">0</xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="normalize-space(@QUANTITY)" />
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:variable>
              <Cell ss:StyleID="QuantityValueStyle" ss:Index="3">
                <Data ss:Type="Number">
                  <xsl:value-of select="$testValueOfQUANTITY" disable-output-escaping="yes" />
                </Data>
                <xsl:if test="string(number(@QUANTITY))='NaN'">
                  <Comment ss:Autor="SYNTEC-PC6\fernandogarciavega">
                    <ss:Data xmlns="http://www.w3.org/TR/REC-html40">
                      <Font html:Face="Segoe UI" html:Size="10" html:Color="#000000">
                        <xsl:value-of select="@QUANTITY" />
                      </Font>
                    </ss:Data>
                  </Comment>
                </xsl:if>
                <NamedCell ss:Name="_FilterDatabase" />
              </Cell>
              <xsl:variable name="testValueOfPRICE">
                <xsl:choose>
                  <xsl:when test="string(number(normalize-space(@PRICE)))='NaN'">0</xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="normalize-space(@PRICE)" />
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:variable>
              <Cell ss:StyleID="PriceValueStyle" ss:Index="4">
                <Data ss:Type="Number">
                  <xsl:value-of select="$testValueOfPRICE" disable-output-escaping="yes" />
                </Data>
                <xsl:if test="string(number(@PRICE))='NaN'">
                  <Comment ss:Autor="SYNTEC-PC6\fernandogarciavega">
                    <ss:Data xmlns="http://www.w3.org/TR/REC-html40">
                      <Font html:Face="Segoe UI" html:Size="10" html:Color="#000000">
                        <xsl:value-of select="@PRICE" />
                      </Font>
                    </ss:Data>
                  </Comment>
                </xsl:if>
                <NamedCell ss:Name="_FilterDatabase" />
              </Cell>
              <xsl:variable name="testValueOfVALUE">
                <xsl:choose>
                  <xsl:when test="string(number(normalize-space(@VALUE)))='NaN'">0</xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="normalize-space(@VALUE)" />
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:variable>
              <Cell ss:StyleID="ValueValueStyle" ss:Index="5">
                <Data ss:Type="Number">
                  <xsl:value-of select="$testValueOfVALUE" disable-output-escaping="yes" />
                </Data>
                <xsl:if test="string(number(@VALUE))='NaN'">
                  <Comment ss:Autor="SYNTEC-PC6\fernandogarciavega">
                    <ss:Data xmlns="http://www.w3.org/TR/REC-html40">
                      <Font html:Face="Segoe UI" html:Size="10" html:Color="#000000">
                        <xsl:value-of select="@VALUE" />
                      </Font>
                    </ss:Data>
                  </Comment>
                </xsl:if>
                <NamedCell ss:Name="_FilterDatabase" />
              </Cell>
            </Row>
          </xsl:for-each>
          <Row>
            <Cell ss:Index="1" ss:StyleID="IdAggregateStyle" />
            <Cell ss:Index="2" ss:StyleID="ProductAggregateStyle" />
            <Cell ss:Index="3" ss:StyleID="QuantityAggregateStyle" ss:Formula="SUBTOTAL(109,R[-{$__rows}]C:R[-1]C)" />
            <Cell ss:Index="4" ss:StyleID="PriceAggregateStyle" ss:Formula="SUBTOTAL(109,R[-{$__rows}]C:R[-1]C)" />
            <Cell ss:Index="5" ss:StyleID="ValueAggregateStyle" ss:Formula="SUBTOTAL(109,R[-{$__rows}]C:R[-1]C)" />
          </Row>
        </Table>
        <WorksheetOptions xmlns="urn:schemas-microsoft-com:office:excel">
          <PageSetup>
            <Layout x:Orientation="Portrait" />
            <PageMargins x:Bottom="0.7874016" x:Left="0.7874016" x:Right="0.7874016" x:Top="0.7874016" />
          </PageSetup>
          <Print>
            <ValidPrinterInfo />
            <PaperSizeIndex>9</PaperSizeIndex>
            <HorizontalResolution>600</HorizontalResolution>
            <VerticalResolution>600</VerticalResolution>
          </Print>
        </WorksheetOptions>
        <AutoFilter x:Range="R{$__TableRange_Y1}C{$__TableRange_X1}:R{$__TableRange_Y2}C{$__TableRange_X2}" xmlns="urn:schemas-microsoft-com:office:excel" />
      </Worksheet>
    </Workbook>
  </xsl:template>
</xsl:stylesheet>