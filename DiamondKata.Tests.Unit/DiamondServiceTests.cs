using DiamondKata.Console;
using FluentAssertions;
using System.Collections.Generic;
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
}
