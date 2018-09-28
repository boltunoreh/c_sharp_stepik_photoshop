using System;

namespace MyPhotoshop
{
    public class DesaturateFilter : PixelFilter
    {
        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public override string ToString()
        {
            return "Desaturate";
        }

        protected override Pixel ProcessPixel(Pixel original, double[] parameters)
        {
            double lightnes = (original.R + original.G + original.B) / 3;
            return new Pixel(lightnes, lightnes, lightnes);
        }
    }
}