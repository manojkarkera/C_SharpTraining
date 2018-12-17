using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
   public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        //public void Processor(string path,PhotoFilterHandler filterHandler)
        //{
        //    var photo = Photo.Load(path);
        //   //System.Action, return void
        //   //System.Func, return value
        //    var filters = new PhotoFilters();
        //    filterHandler(photo);

        //    //filters.ApplyBrightness(photo);
        //    //filters.ApplyContrast(photo);
        //    //filters.Resize(photo);

        //    photo.Save();
        //}

  
        public void Processor(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            //System.Action, return void
            //System.Func, return value
            var filters = new PhotoFilters();
            filterHandler(photo);

            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
