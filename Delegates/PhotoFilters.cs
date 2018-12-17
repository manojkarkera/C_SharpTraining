using System;

namespace Delegates
{
    internal class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("ApplyBrightness");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("ApplyContrast");
        }

        internal void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}