using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey,TValue>
    {
        public void Add(TKey key,TValue value)
        {

        }
    }

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    /*
     where T : IComparable
     where T : Product, subclass
     where T : struct
     where T : class
     where T : new()
         */

    // where T : IComparable;  where T : new()
    public class Utilities<T> where T : IComparable,new()
    {
        public int Max(int a,int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();

        }

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}

        public T Max(T a, T b) //where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    //where T : Product
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;

        }
    }

    // where T : struct
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { Isbn = "1111", Title = "C# book" };

            ////OLD WAY
            //var numbers = new List();
            //numbers.Add(5);

            //var books = new BookList();
            //books.Add(book);

            //var numbers1 = new GenericList<int>();
            //numbers1.Add(10);

            //var books1 = new GenericList<Book>();
            //books1.Add(book);

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", book);

            var number = new Nullable<int>();
            Console.WriteLine("Has value :- " + number.HasValue);
            Console.WriteLine("Value :-" +  number.GetValueOrDefault());

            Console.ReadKey();


        }
    }
}
