using System.Collections.Generic;
using ElectronicColorCode;
using Xunit;

namespace ElectronicColorCode.Test
{
    public class ColorBandTest
    {
        [Theory]
        [InlineData("pink", "Pink")]
        [InlineData("PINK", "Pink")]
        [InlineData("Pink", "Pink")]
        [InlineData(" pink", "Pink")]
        [InlineData("PK", "Pink")]
        [InlineData("pk", "Pink")]
        [InlineData("silver", "Silver")]
        [InlineData("SILVER", "Silver")]
        [InlineData("sIlver", "Silver")]
        [InlineData("SILVER ", "Silver")]
        [InlineData("SR", "Silver")]
        [InlineData("sR", "Silver")]
        [InlineData("gold", "Gold")]
        [InlineData("GOLD", "Gold")]
        [InlineData("goLd", "Gold")]
        [InlineData(" goLd ", "Gold")]
        [InlineData("GD", "Gold")]
        [InlineData("Gd", "Gold")]
        [InlineData("black", "Black")]
        [InlineData("BLACK", "Black")]
        [InlineData("blaCk", "Black")]
        [InlineData("\tblack", "Black")]
        [InlineData("BK", "Black")]
        [InlineData("bk", "Black")]
        [InlineData("brown", "Brown")]
        [InlineData("BROWN", "Brown")]
        [InlineData("browN", "Brown")]
        [InlineData("BROWN\r", "Brown")]
        [InlineData("BN", "Brown")]
        [InlineData("Bn", "Brown")]
        [InlineData("red", "Red")]
        [InlineData("RED", "Red")]
        [InlineData("REd", "Red")]
        [InlineData("\nREd\r\n", "Red")]
        [InlineData("RD", "Red")]
        [InlineData("rD", "Red")]
        [InlineData("orange", "Orange")]
        [InlineData("ORANGE", "Orange")]
        [InlineData("OrAnge", "Orange")]
        [InlineData("OG", "Orange")]
        [InlineData(" OG", "Orange")]
        [InlineData("yellow", "Yellow")]
        [InlineData("YELLOW", "Yellow")]
        [InlineData("YelLow", "Yellow")]
        [InlineData("YE", "Yellow")]
        [InlineData("YE ", "Yellow")]
        [InlineData("green", "Green")]
        [InlineData("GREEN", "Green")]
        [InlineData("GreeN", "Green")]
        [InlineData("GN", "Green")]
        [InlineData(" GN ", "Green")]
        [InlineData("blue", "Blue")]
        [InlineData("BLUE", "Blue")]
        [InlineData("bLUe", "Blue")]
        [InlineData("BU", "Blue")]
        [InlineData("\nBU", "Blue")]
        [InlineData("violet", "Violet")]
        [InlineData("VIOLET", "Violet")]
        [InlineData("vIoLet", "Violet")]
        [InlineData("VT", "Violet")]
        [InlineData("VT\t", "Violet")]
        [InlineData("grey", "Grey")]
        [InlineData("GREY", "Grey")]
        [InlineData("grEY", "Grey")]
        [InlineData("GY", "Grey")]
        [InlineData("\rGY ", "Grey")]
        [InlineData("white", "White")]
        [InlineData("WHITE", "White")]
        [InlineData("wHitE", "White")]
        [InlineData("WH", "White")]
        [InlineData("   WH", "White")]
        public void TestTryParse(string validInput, string expected)
        {
            if (ColorBand.TryParse(validInput, out var colorBand))
            {
                Assert.Equal(expected, colorBand.Name);
            }
            else
            {
                Assert.True(false, $"expected '{validInput}' to parse as '{expected}'");
            }
        }

        [Theory]
        [MemberData(nameof(SignificantFigureData))]
        public void TestSignificantFigure(ColorBand colorBand, int? expected)
        {
            Assert.Equal(expected, colorBand.SignificantFigure);
        }

        public static IEnumerable<object[]> SignificantFigureData()
        {
            yield return new object[] { ColorBand.Pink, null };
            yield return new object[] { ColorBand.Silver, null };
            yield return new object[] { ColorBand.Gold, null };
            yield return new object[] { ColorBand.Black, 0 };
            yield return new object[] { ColorBand.Brown, 1 };
            yield return new object[] { ColorBand.Red, 2 };
            yield return new object[] { ColorBand.Orange, 3 };
            yield return new object[] { ColorBand.Yellow, 4 };
            yield return new object[] { ColorBand.Green, 5 };
            yield return new object[] { ColorBand.Blue, 6 };
            yield return new object[] { ColorBand.Violet, 7 };
            yield return new object[] { ColorBand.Grey, 8 };
            yield return new object[] { ColorBand.White, 9 };
            yield break;
        }
    }
}
