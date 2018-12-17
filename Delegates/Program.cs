using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            //filterHandler += filter.ApplyContrast;
            //filterHandler += RemovedRedEyeFilter;

            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemovedRedEyeFilter;
            processor.Processor("photo.jpg", filterHandler);
            Console.ReadKey();
        }

        static void RemovedRedEyeFilter(Photo photo)
        {
            Console.WriteLine("RemovedRedEyeFilter");
        
        }
    }
}
