using System;
using Xunit;

namespace ElectronicColorCode.Test
{
    public class OhmValuesCalculatorTest
    {
        [Theory]
        [InlineData(null, null, null, null, "bandAColor")]
        [InlineData("orange", null, null, null, "bandBColor")]
        [InlineData("red", "brown", null, null, "bandCColor")]
        [InlineData("green", "black", "white", null, "bandDColor")]
        public void TestOhmValuesCalculatorNullValues(string first, string second, string third, string fourth, string expected)
        {
            var sut = new OhmValuesCalculator();

            var exception = Assert.Throws<ArgumentNullException>(() => sut.CalculateOhmValue(first, second, third, fourth));

            Assert.Equal(expected, exception.ParamName);
        }

        [Theory]
        [InlineData("invalid", "bad", "garbage", "trash", "bandAColor")]
        [InlineData("orange", "no good", "will not parse", "fail", "bandBColor")]
        [InlineData("red", "brown", "problem", "error", "bandCColor")]
        [InlineData("green", "black", "white", "err", "bandDColor")]
        public void TestOhmValuesCalculatorInvalidValues(string first, string second, string third, string fourth, string expected)
        {
            var sut = new OhmValuesCalculator();

            var exception = Assert.Throws<ArgumentException>(() => sut.CalculateOhmValue(first, second, third, fourth));

            Assert.Equal(expected, exception.ParamName);
        }

        [Theory]
        [InlineData("pink", "red", "yellow", "orange", "bandAColor")]
        [InlineData("silver", "black", "brown", "green", "bandAColor")]
        [InlineData("gold", "blue", "violet", "gold", "bandAColor")]
        [InlineData("blue", "pink", "red", "silver", "bandBColor")]
        [InlineData("grey", "silver", "green", "orange", "bandBColor")]
        [InlineData("white", "gold", "white", "white", "bandBColor")]
        public void TestOhmValuesCalculatorInvalidBands(string first, string second, string third, string fourth, string expected)
        {
            var sut = new OhmValuesCalculator();

            var exception = Assert.Throws<ArgumentException>(() => sut.CalculateOhmValue(first, second, third, fourth));

            Assert.Equal(expected, exception.ParamName);
        }
    }
}
