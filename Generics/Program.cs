using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            sehirler[0] = "Istanbul"; //set
            Console.WriteLine(sehirler[0]);  //get
            Console.WriteLine(sehirler.Count);

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            sehirler2[0] = "Istanbul"; //indexing, koseli parantezi class gibi kullanmaya indexing denir
            Console.WriteLine(sehirler2.Count);
            Console.WriteLine(sehirler2[0]);

            foreach (var sehir in sehirler2.Items)
            {
                Console.WriteLine(sehir);
            }

        }
    }

    class MyList<T> //Generic class, <T> = type
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get
            { 
                return _array; 
            }
        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = value;
            }
        }

    }
}
