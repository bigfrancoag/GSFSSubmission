using System;

namespace ElectronicColorCode
{
    public class ColorBand
    {
        public static readonly ColorBand Pink = new ColorBand(nameof(Pink));
        public static readonly ColorBand Silver = new ColorBand(nameof(Silver));
        public static readonly ColorBand Gold = new ColorBand(nameof(Gold));
        public static readonly ColorBand Black = new ColorBand(nameof(Black));
        public static readonly ColorBand Brown = new ColorBand(nameof(Brown));
        public static readonly ColorBand Red = new ColorBand(nameof(Red));
        public static readonly ColorBand Orange = new ColorBand(nameof(Orange));
        public static readonly ColorBand Yellow = new ColorBand(nameof(Yellow));
        public static readonly ColorBand Green = new ColorBand(nameof(Green));
        public static readonly ColorBand Blue = new ColorBand(nameof(Blue));
        public static readonly ColorBand Violet = new ColorBand(nameof(Violet));
        public static readonly ColorBand Grey = new ColorBand(nameof(Grey));
        public static readonly ColorBand White = new ColorBand(nameof(White));

        public string Name { get; }

        private ColorBand(string name)
        {
            Name = name;
        }

        public static bool TryParse(string input, out ColorBand colorBand)
        {
            if (input == null)
            {
                throw new NotImplementedException();
            }

            switch (input.Trim().ToLower())
            {
                case "pink":
                    colorBand = ColorBand.Pink;
                    return true;

                case "silver":
                    colorBand = ColorBand.Silver;
                    return true;

                case "gold":
                    colorBand = ColorBand.Gold;
                    return true;

                case "black":
                    colorBand = ColorBand.Black;
                    return true;

                case "brown":
                    colorBand = ColorBand.Brown;
                    return true;

                case "red":
                    colorBand = ColorBand.Red;
                    return true;

                case "orange":
                    colorBand = ColorBand.Orange;
                    return true;

                case "yellow":
                    colorBand = ColorBand.Yellow;
                    return true;

                case "green":
                    colorBand = ColorBand.Green;
                    return true;

                case "blue":
                    colorBand = ColorBand.Blue;
                    return true;

                case "violet":
                    colorBand = ColorBand.Violet;
                    return true;

                case "grey":
                    colorBand = ColorBand.Grey;
                    return true;

                case "white":
                    colorBand = ColorBand.White;
                    return true;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
