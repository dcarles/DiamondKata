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
        var result = _diamondService.RenderDiamond('A');
        result.Should().Be("A");
    }

    [Fact]
    public void RenderDiamond_WhenB_ReturnABDiamond()
    {
        var expectedDiamond = new StringBuilder();
        expectedDiamond.AppendLine(" A ");
        expectedDiamond.AppendLine("B B");    
        expectedDiamond.AppendLine(" A ");

        var result = _diamondService.RenderDiamond('B');
        result.Should().Be(expectedDiamond.ToString());
    }
}
