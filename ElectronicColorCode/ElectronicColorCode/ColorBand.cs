using System;

namespace ElectronicColorCode
{
    public class ColorBand
    {
        public static readonly ColorBand Pink = new ColorBand(nameof(Pink), null, 0);
        public static readonly ColorBand Silver = new ColorBand(nameof(Silver), null, 0);
        public static readonly ColorBand Gold = new ColorBand(nameof(Gold), null, 0);
        public static readonly ColorBand Black = new ColorBand(nameof(Black), 0, 1);
        public static readonly ColorBand Brown = new ColorBand(nameof(Brown), 1, 10);
        public static readonly ColorBand Red = new ColorBand(nameof(Red), 2, 100);
        public static readonly ColorBand Orange = new ColorBand(nameof(Orange), 3, 1000);
        public static readonly ColorBand Yellow = new ColorBand(nameof(Yellow), 4, 10000);
        public static readonly ColorBand Green = new ColorBand(nameof(Green), 5, 100000);
        public static readonly ColorBand Blue = new ColorBand(nameof(Blue), 6, 1000000);
        public static readonly ColorBand Violet = new ColorBand(nameof(Violet), 7, 10000000);
        public static readonly ColorBand Grey = new ColorBand(nameof(Grey), 8, 100000000);
        public static readonly ColorBand White = new ColorBand(nameof(White), 9, 1000000000);

        public string Name { get; }
        public int? SignificantFigure { get; }
        public int Multiplier { get; }

        private ColorBand(string name, int? significantFigure, int multiplier)
        {
            Name = name;
            SignificantFigure = significantFigure;
            Multiplier = multiplier;
        }

        public static bool TryParse(string input, out ColorBand colorBand)
        {
            colorBand = null;
            if (input == null)
            {
                return false;
            }

            switch (input.Trim().ToLower())
            {
                case "pink":
                case "pk":
                    colorBand = ColorBand.Pink;
                    return true;

                case "silver":
                case "sr":
                    colorBand = ColorBand.Silver;
                    return true;

                case "gold":
                case "gd":
                    colorBand = ColorBand.Gold;
                    return true;

                case "black":
                case "bk":
                    colorBand = ColorBand.Black;
                    return true;

                case "brown":
                case "bn":
                    colorBand = ColorBand.Brown;
                    return true;

                case "red":
                case "rd":
                    colorBand = ColorBand.Red;
                    return true;

                case "orange":
                case "og":
                    colorBand = ColorBand.Orange;
                    return true;

                case "yellow":
                case "ye":
                    colorBand = ColorBand.Yellow;
                    return true;

                case "green":
                case "gn":
                    colorBand = ColorBand.Green;
                    return true;

                case "blue":
                case "bu":
                    colorBand = ColorBand.Blue;
                    return true;

                case "violet":
                case "vt":
                    colorBand = ColorBand.Violet;
                    return true;

                case "grey":
                case "gy":
                    colorBand = ColorBand.Grey;
                    return true;

                case "white":
                case "wh":
                    colorBand = ColorBand.White;
                    return true;

                default:
                    return false;
            }
        }
    }
}
