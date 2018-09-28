using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            R = CheckValue(r);
            G = CheckValue(g);
            B = CheckValue(b);
        }

        public double R { get; private set; }

        public double G { get; private set; }

        public double B { get; private set; }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }

        private static double CheckValue(double value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException($"Wrong channel value {value} (the value must be between 0 and 1");
            }

            return value;
        }

        public static Pixel operator *(Pixel pixel, double multiplier)
        {
            pixel.R = Trim(pixel.R * multiplier);
            pixel.G = Trim(pixel.G * multiplier);
            pixel.B = Trim(pixel.B * multiplier);

            return pixel;
        }

        public static Pixel operator *(double multiplier, Pixel pixel)
        {
            return pixel * multiplier;
        }
    }
}