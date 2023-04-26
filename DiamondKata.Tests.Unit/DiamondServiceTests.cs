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
    public void RenderDiamond_WhenA_ReturnA()
    {
        // Arrange
        var expected = "A";

        //Act
        var result = _diamondService.RenderDiamond('A');

        //Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void RenderDiamond_WhenB_ReturnABDiamond()
    {
        // Arrange
        var expectedDiamond = new StringBuilder();
        expectedDiamond.AppendLine(" A ");
        expectedDiamond.AppendLine("B B");    
        expectedDiamond.AppendLine(" A ");

        //Act
        var result = _diamondService.RenderDiamond('B');

        //Assert
        result.Should().Be(expectedDiamond.ToString());
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
        Assert.Equal(expectedRow, actualRow);
    }
}
