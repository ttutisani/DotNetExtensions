using Xunit;
using FluentAssertions;

namespace DotNetExtensions.UnitTests
{
    public sealed class ReadOnlyTests
    {
        [Fact]
        public void Ctor_Without_Args_Sets_Value_To_Default()
        {
            //act.
            var sut = new ReadOnly<int>();

            //assert.
            sut.Value.Should().Be(0);
        }

        [Fact]
        public void Ctor_With_Arg_Sets_Value_To_Arg()
        {
            //arrange.
            var expectedValue = 123;

            //act.
            var sut = new ReadOnly<int>(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Conversion_Gets_Original_Value()
        {
            //arrange.
            var originalValue = 321;
            var sut = new ReadOnly<int>(originalValue);

            //act.
            int convertedValue = sut;

            //assert.
            convertedValue.Should().Be(originalValue);
        }

        [Fact]
        public void Static_Value_Creates_Readonly_By_Value()
        {
            //arrange.
            var expectedValue = 1616;

            //act.
            var sut = ReadOnly.Value(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void AsReadOnly_Creates_ReadOnly_By_Value()
        {
            //arrange.
            var expectedValue = 5541;

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            sut.Value.Should().Be(expectedValue);
        }
    }
}
