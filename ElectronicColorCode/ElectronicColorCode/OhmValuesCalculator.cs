using System;

namespace ElectronicColorCode
{
    public class OhmValuesCalculator : ICalculateOhmValues
    {
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            var firstDigit = ParseFirstSignificantFigure(bandAColor);
            var secondDigit = ParseSecondSignificantFigure(bandBColor);
            var multiplier = ParseMultiplier(bandCColor);
            ParseTolerance(bandDColor);

            return (firstDigit * 10 + secondDigit) * multiplier;
        }

        private static int ParseFirstSignificantFigure(string bandAColor)
        {
            if (bandAColor == null)
            {
                throw new ArgumentNullException(nameof(bandAColor));
            }

            if (!ColorBand.TryParse(bandAColor, out var colorBandA))
            {
                throw new ArgumentException($"unable to parse: {bandAColor}", nameof(bandAColor));
            }
            else if (colorBandA == ColorBand.Pink || colorBandA == ColorBand.Silver || colorBandA == ColorBand.Gold)
            {
                throw new ArgumentException($"invalid color for first significant figure: {bandAColor}", nameof(bandAColor));
            }

            return colorBandA.SignificantFigure.Value;
        }

        private static int ParseSecondSignificantFigure(string bandBColor)
        {
            if (bandBColor == null)
            {
                throw new ArgumentNullException(nameof(bandBColor));
            }

            if (!ColorBand.TryParse(bandBColor, out var colorBandB))
            {
                throw new ArgumentException($"unable to parse: {bandBColor}", nameof(bandBColor));
            }
            else if (colorBandB == ColorBand.Pink || colorBandB == ColorBand.Silver || colorBandB == ColorBand.Gold)
            {
                throw new ArgumentException($"invalid color for second significant figure: {bandBColor}", nameof(bandBColor));
            }
            
            return colorBandB.SignificantFigure.Value;
        }

        private static int ParseMultiplier(string bandCColor)
        {
            if (bandCColor == null)
            {
                throw new ArgumentNullException(nameof(bandCColor));
            }

            if (!ColorBand.TryParse(bandCColor, out var colorBandC))
            {
                throw new ArgumentException($"unable to parse: {bandCColor}", nameof(bandCColor));
            }

            return colorBandC.Multiplier;
        }

        private static void ParseTolerance(string bandDColor)
        {
            if (bandDColor == null)
            {
                throw new ArgumentNullException(nameof(bandDColor));
            }

            if (!ColorBand.TryParse(bandDColor, out var colorBandD))
            {
                throw new ArgumentException($"unable to parse: {bandDColor}", nameof(bandDColor));
            }
        }
    }
}
