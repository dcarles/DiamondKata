using DiamondKata.Console;
using FluentAssertions;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DiamondKata.Tests.Unit;

public class DiamondServiceTests
{
    private readonly DiamondService _diamondService;
    public DiamondServiceTests()
    {
        _diamondService = new DiamondService();
    }

    [Fact]
    public void RenderDiamond_WhenA_ReturnsA()
    {
        // Arrange
        var expectedDiamond = "A";

        //Act
        var actualDiamond = _diamondService.RenderDiamond('A');

        //Assert
        actualDiamond.Should().Be(expectedDiamond);
    }

    [Fact]
    public void RenderDiamond_WhenB_ReturnsCorrectABDiamond()
    {
        // Arrange
        var expectedDiamond = new StringBuilder();
        expectedDiamond.AppendLine(" A ");
        expectedDiamond.AppendLine("B B");    
        expectedDiamond.AppendLine(" A ");

        //Act
        var actualDiamond = _diamondService.RenderDiamond('B');

        //Assert
        actualDiamond.Should().Be(expectedDiamond.ToString());
    }

    [Fact]
    public void RenderDiamond_WhenC_ReturnsCorrectABCDiamond()
    {
        //Arrange
        var expectedDiamond = new StringBuilder();
        expectedDiamond.AppendLine("  A  ");
        expectedDiamond.AppendLine(" B B ");
        expectedDiamond.AppendLine("C   C");
        expectedDiamond.AppendLine(" B B ");
        expectedDiamond.AppendLine("  A  ");

        //Act
        var actualDiamond = _diamondService.RenderDiamond('C');

        //Assert
        actualDiamond.Should().Be(expectedDiamond.ToString());
    }

    [Fact]
    public void RenderDiamond_WhenH_ReturnsCorrectHDiamond()
    {
        //Arrange
        var expectedDiamond = new StringBuilder();
        expectedDiamond.AppendLine("       A       ");
        expectedDiamond.AppendLine("      B B      ");
        expectedDiamond.AppendLine("     C   C     ");
        expectedDiamond.AppendLine("    D     D    ");
        expectedDiamond.AppendLine("   E       E   ");
        expectedDiamond.AppendLine("  F         F  ");
        expectedDiamond.AppendLine(" G           G ");
        expectedDiamond.AppendLine("H             H");
        expectedDiamond.AppendLine(" G           G ");
        expectedDiamond.AppendLine("  F         F  ");
        expectedDiamond.AppendLine("   E       E   ");
        expectedDiamond.AppendLine("    D     D    ");
        expectedDiamond.AppendLine("     C   C     ");
        expectedDiamond.AppendLine("      B B      ");
        expectedDiamond.AppendLine("       A       ");

        //Act
        var actualDiamond = _diamondService.RenderDiamond('H');

        //Assert
        actualDiamond.Should().Be(expectedDiamond.ToString());
    }


    [Fact]
    public void RenderRow_WithMinimumValues_ReturnsA()
    {
        // Arrange
        int numberOfRows = 1;
        int rowIndex = 0;
        var expectedRow = "A";

        // Act
        var actualRow = _diamondService.RenderRow(numberOfRows, rowIndex);

        // Assert
        actualRow.Should().Be(expectedRow);
       
    }

    [Fact]
    public void RenderRow_With2RowsIndex1_ReturnsBBRowWithCorrectInternalPadding()
    {
        // Arrange
        int numberOfRows = 2;
        int rowIndex = 1;
        var expectedRow = "B B";

        // Act
        var actualRow = _diamondService.RenderRow(numberOfRows, rowIndex);

        // Assert
        actualRow.Should().Be(expectedRow);
    }

    [Fact]
    public void RenderRow_RowAAndMultipleRows_ReturnsAWithCorrectExternalPadding()
    {
        // Arrange
        int numberOfRows = 5;
        int rowIndex = 0;
        string expectedRow = "    A    ";

        // Act
        string actualRow = _diamondService.RenderRow(numberOfRows, rowIndex);

        // Assert
        actualRow.Should().Be(expectedRow);
    }

    [Fact]
    public void RenderRow_WithMaximumValues_ReturnsExpectedRowZWithCorrectInternalPaddingAndNoExternalPadding()
    {
        // Arrange
        int numberOfRows = 26;
        int rowIndex = 25;
        string expectedRow = "Z                                                 Z";

        // Act
        string actualRow = _diamondService.RenderRow(numberOfRows, rowIndex);

        // Assert
        actualRow.Should().Be(expectedRow);
    }

    [Fact]
    public void RenderRow_With5RowsAndIndex2_ReturnsCRowWithCorrectInternalAndExternalPadding()
    {
        // Arrange
        int numberOfRows = 5;
        int rowIndex = 2;
        string expectedRow = "  C   C  ";

        // Act
        string actualRow = _diamondService.RenderRow(numberOfRows, rowIndex);

        // Assert
        actualRow.Should().Be(expectedRow);
    }

}
