using Xunit;
using FluentAssertions;

namespace DotNetExtensions.UnitTests
{
    public sealed class TryParseTests
    {
        [Fact]
        public void Convert_allows_calling_convertible_functions()
        {
            //arrange.
            var expectedValue = 123;

            //act.
            var value = $"{expectedValue}".Convert().ToInt32(null);

            //assert.
            value.Should().Be(expectedValue);
        }

        [Fact]
        public void ToInt_returns_string_as_int_if_valid_number()
        {
            //arrange.
            var expectedValue = 123;

            //act.
            var value = $"{expectedValue}".ToInt();

            //assert.
            value.Should().Be(expectedValue);
        }

        [Fact]
        public void ToInt_Returns_0_if_no_default_value_specificed()
        {
            //act.
            var value = "123 not a number".ToInt();

            //assert.
            value.Should().Be(0);
        }

        [Fact]
        public void ToInt_returns_default_value_if_specified()
        {
            //arrange.
            var defaultValue = -1;

            //act.
            var value = "not a number".ToInt(defaultValue);

            //assert.
            value.Should().Be(defaultValue);
        }
    }
}
