using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(38, "Kayseri");
            sehirler.Add(44, "Malatya");
            Console.WriteLine(sehirler.Count);
            Console.WriteLine(sehirler[38]);

            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();
            sehirler2.Add(38, "Kayseri");
            sehirler2.Add(44, "Malatya");
            Console.WriteLine(sehirler2.Count);
            Console.WriteLine(sehirler[44]);
        }
    class MyDictionary<A,B>
        {
            A[] _arrayKey;
            B[] _arrayValue;

            A[] _tempArrayKey;
            B[] _tempArrayValue;

            public MyDictionary()
            {
                _arrayKey = new A[0];
                _arrayValue = new B[0];
            }

            public void Add(A key, B value)
            {
                _tempArrayKey = _arrayKey;
                _tempArrayValue = _arrayValue;

                _arrayKey = new A[_arrayKey.Length + 1];
                _arrayValue = new B[_arrayValue.Length + 1];

                for (int i = 0; i < _tempArrayKey.Length; i++)
                {
                    _arrayKey[i] = _tempArrayKey[i];
                }
                _arrayKey[_arrayKey.Length - 1] = key;

                for (int i = 0; i < _tempArrayValue.Length; i++)
                {
                    _arrayValue[i] = _tempArrayValue[i];
                }
                _arrayValue[_arrayValue.Length - 1] = value;
            }
            public int Count
            {
                get { return _arrayKey.Length; }
            }
        }
    }
}
