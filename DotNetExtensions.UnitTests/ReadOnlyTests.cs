using Xunit;
using FluentAssertions;

namespace DotNetExtensions.UnitTests
{
    public sealed class ReadOnlyTests
    {
        [Fact]
        public void Ctor_without_args_sets_int_value_to_default()
        {
            //act.
            var sut = new ReadOnly<int>();

            //assert.
            sut.Value.Should().Be(0);
        }

        [Fact]
        public void Ctor_without_args_sets_string_value_to_default()
        {
            //act.
            var sut = new ReadOnly<string>();

            //assert.
            sut.Value.Should().Be(null);
        }

        [Fact]
        public void Ctor_with_arg_sets_int_value_to_arg()
        {
            //arrange.
            var expectedValue = 123;

            //act.
            var sut = new ReadOnly<int>(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Ctor_with_arg_sets_string_value_to_arg()
        {
            //arrange.
            var expectedValue = "abc";

            //act.
            var sut = new ReadOnly<string>(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Ctor_with_arg_sets_string_value_to_arg_null()
        {
            //arrange.
            string expectedValue = null;

            //act.
            var sut = new ReadOnly<string>(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Conversion_gets_original_int_value()
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
        public void Conversion_gets_original_string_value()
        {
            //arrange.
            var originalValue = "bdba";
            var sut = new ReadOnly<string>(originalValue);

            //act.
            string convertedValue = sut;

            //assert.
            convertedValue.Should().Be(originalValue);
        }

        [Fact]
        public void Conversion_gets_original_string_value_null()
        {
            //arrange.
            string originalValue = null;
            var sut = new ReadOnly<string>(originalValue);

            //act.
            string convertedValue = sut;

            //assert.
            convertedValue.Should().Be(originalValue);
        }

        [Fact]
        public void Static_value_creates_ReadOnly_by_int_value()
        {
            //arrange.
            var expectedValue = 1616;

            //act.
            var sut = ReadOnly.Value(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Static_value_creates_ReadOnly_by_string_value()
        {
            //arrange.
            var expectedValue = "ajkshajhs";

            //act.
            var sut = ReadOnly.Value(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void Static_value_creates_ReadOnly_by_string_value_null()
        {
            //arrange.
            string expectedValue = null;

            //act.
            var sut = ReadOnly.Value(expectedValue);

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void AsReadOnly_creates_ReadOnly_by_int_value()
        {
            //arrange.
            var expectedValue = 5541;

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void AsReadOnly_creates_ReadOnly_by_string_value()
        {
            //arrange.
            var expectedValue = "ajhn2n";

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void AsReadOnly_creates_ReadOnly_by_string_value_null()
        {
            //arrange.
            string expectedValue = null;

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            sut.Value.Should().Be(expectedValue);
        }

        [Fact]
        public void String_representation_gives_original_int_value()
        {
            //arrange.
            var expectedValue = 1414;

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            $"{sut}".Should().Be($"{expectedValue}");
        }

        [Fact]
        public void String_representation_gives_original_string_value()
        {
            //arrange.
            var expectedValue = "a2ab";

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            $"{sut}".Should().Be($"{expectedValue}");
        }

        [Fact]
        public void String_representation_gives_original_string_value_null()
        {
            //arrange.
            string expectedValue = null;

            //act.
            var sut = expectedValue.AsReadOnly();

            //assert.
            $"{sut}".Should().Be($"{expectedValue}");
        }

        [Fact]
        public void ReadOnly_should_equal_original_int_for_comparison()
        {
            //arrange.
            var originalValue = 717;
            var sut = originalValue.AsReadOnly();

            //act.
            var equal = sut == originalValue;

            //assert.
            equal.Should().BeTrue();
        }

        [Fact]
        public void ReadOnly_should_equal_original_string_for_comparison()
        {
            //arrange.
            var originalValue = "magt1";
            var sut = originalValue.AsReadOnly();

            //act.
            var equal = sut == originalValue;

            //assert.
            equal.Should().BeTrue();
        }

        [Fact]
        public void ReadOnly_should_equal_original_string_for_comparison_null()
        {
            //arrange.
            string originalValue = null;
            var sut = originalValue.AsReadOnly();

            //act.
            var equal = sut == originalValue;

            //assert.
            equal.Should().BeTrue();
        }

        [Fact]
        public void ReadOnly_should_equal_other_readonly_with_same_original_int_value()
        {
            //arrange.
            var originalValue = 77177;
            var readOnly1 = originalValue.AsReadOnly();
            var readOnly2 = originalValue.AsReadOnly();

            //act.
            var equal = readOnly1 == readOnly2;

            //assert.
            equal.Should().BeTrue();
        }

        [Fact]
        public void ReadOnly_should_equal_other_readonly_with_same_original_string_value()
        {
            //arrange.
            var originalValue = "12haha";
            var readOnly1 = originalValue.AsReadOnly();
            var readOnly2 = originalValue.AsReadOnly();

            //act.
            var equal = readOnly1 == readOnly2;

            //assert.
            equal.Should().BeTrue();
        }

        [Fact]
        public void ReadOnly_should_equal_other_readonly_with_same_original_string_value_null()
        {
            //arrange.
            string originalValue = null;
            var readOnly1 = originalValue.AsReadOnly();
            var readOnly2 = originalValue.AsReadOnly();

            //act.
            var equal = readOnly1 == readOnly2;

            //assert.
            equal.Should().BeTrue();
        }
    }
}
