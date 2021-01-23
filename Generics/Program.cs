using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İzmir");

            Console.WriteLine(sehirler2.Count);

        }

        class MyList<T>
        {
            T[] _items;

            public MyList()
            {
                _items = new T[0];
            }

            public void Add(T item)
            {
                T[] tempArray = _items;
                _items = new T[_items.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    _items[i] = tempArray[i];
                }

                _items[_items.Length - 1] = item;
            }

            public int Count
            {
                get { return _items.Length; }
            }
        }
    }
}
