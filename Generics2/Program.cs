using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            //sehirler.Count = 3; //hata verir. çünkü count List için get olarak kullanılabilir. Set edilemiyor.
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }

    class MyList<T>
        {
            T[] _array;
            T[] _tempArray;     //_array = new T[_array.Length + 1]; yaptığmızda elemanlarımız new den dolayı silinmesin diye oluşturduk.

            public MyList()  //ctor tab tab----constructor //classın ilk oluşumunu kontrol ettik
            {
                _array = new T[0];
            }
            public void Add(T item)  //MyList için add özelliğini oluşturduk.
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }
            public int Count   //propfull tab tab //count özelliğini ekledik. sadece get olacak list için
            {
                get { return _array.Length; }
            }
        }
    }
}
