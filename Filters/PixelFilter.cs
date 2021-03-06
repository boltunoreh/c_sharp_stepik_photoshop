using System;

namespace MyPhotoshop
{
    public abstract class PixelFilter : IFilter
    {
        public abstract ParameterInfo[] GetParameters();

        public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {

                    result[x, y] = ProcessPixel(original[x, y], parameters);
                }
            }

            return result;
        }

        protected abstract Pixel ProcessPixel(Pixel original, double[] parameters);
    }
}