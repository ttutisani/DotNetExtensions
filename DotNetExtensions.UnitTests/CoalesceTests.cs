using FluentAssertions;
using Xunit;

namespace DotNetExtensions.UnitTests
{
    public sealed class CoalesceTests
    {
        [Theory]
        [InlineData("not null", null, "not null")]
        [InlineData("", null, "")]
        [InlineData("  ", null, "  ")]
        [InlineData("not null", "not null 2", "not null")]
        [InlineData(null, "not null 2", "not null 2")]
        [InlineData(null, "", "")]
        [InlineData(null, "  ", "  ")]
        [InlineData(null, null, null)]
        public void IfNull_Coalesces_Correctly(string value, string alternative, string expected)
        {
            //act.
            var coalesced = value.IfNull(alternative);

            //assert.
            coalesced.Should().Be(expected);
        }

        [Theory]
        [InlineData("not null", null, "not null")]
        [InlineData("", null, null)]
        [InlineData("  ", null, "  ")]
        [InlineData("not null", "not null 2", "not null")]
        [InlineData(null, "not null 2", "not null 2")]
        [InlineData(null, "", "")]
        [InlineData(null, "  ", "  ")]
        [InlineData(null, null, null)]
        public void IfNullOrEmpty_Coalesces_Correctly(string value, string alternative, string expected)
        {
            //act.
            var coalesced = value.IfNullOrEmpty(alternative);

            //assert.
            coalesced.Should().Be(expected);
        }

        [Theory]
        [InlineData("not null", null, "not null")]
        [InlineData("", null, null)]
        [InlineData("  ", null, null)]
        [InlineData("not null", "not null 2", "not null")]
        [InlineData(null, "not null 2", "not null 2")]
        [InlineData(null, "", "")]
        [InlineData(null, "  ", "  ")]
        [InlineData(null, null, null)]
        public void IfNullOrWhiteSpace_Coalesces_Correctly(string value, string alternative, string expected)
        {
            //act.
            var coalesced = value.IfNullOrWhiteSpace(alternative);

            //assert.
            coalesced.Should().Be(expected);
        }
    }
}
