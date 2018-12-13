using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Book : Product
    {
        public string Isbn { get; set; }
       
    }

    public class ObjectList
    {
        public void Add(object value)
        {

        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
