using FluentAssertions;
using Xunit;

namespace DotNetExtensions.UnitTests
{
    public sealed class ValidationsTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        [InlineData("some value", false)]
        public void IsNull_Checks_ForNull_Correctly_string(string value, bool expectedToBeNull)
        {
            //act.
            var isNull = value.IsNull();

            //assert.
            isNull.Should().Be(expectedToBeNull);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("   ", false)]
        [InlineData("some value", false)]
        public void IsNullOrEmpty_Checks_ForNull_Correctly(string value, bool expectedToBeNull)
        {
            //act.
            var isNull = value.IsNullOrEmpty();

            //assert.
            isNull.Should().Be(expectedToBeNull);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("   ", true)]
        [InlineData("some value", false)]
        public void IsNullOrWhiteSpace_Checks_ForNull_Correctly(string value, bool expectedToBeNull)
        {
            //act.
            var isNull = value.IsNullOrWhiteSpace();

            //assert.
            isNull.Should().Be(expectedToBeNull);
        }
    }
}
