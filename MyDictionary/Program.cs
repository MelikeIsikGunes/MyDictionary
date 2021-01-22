using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Student = new MyDictionary<int, string>();
            Student.Add(163, "Melike IŞIK");
            Dictionary<int, string> Student2 = new Dictionary<int, string>();
            Student2.Add(143, "Nurdan Kantarcı");
 
            Console.WriteLine(Student2.Count);
            Console.WriteLine(Student.Count);

            

          
            
        }
    }

    class MyDictionary<TKey,TValue>
    {
        TKey[] _keyArray;  //Key'leri tutan
        TValue[] _valueArray;   //Value'leri tutan

        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKey=_keyArray;
            TValue[] _tempValue=_valueArray;
            _keyArray = new TKey[_keyArray.Length + 1];
            _valueArray = new TValue[_valueArray.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keyArray[i] = _tempKey[i];
                _valueArray[i] = _tempValue[i];
            }

            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_valueArray.Length - 1] = value;
        }

        public int Count
        {
            get { return _keyArray.Length; }
        }
    }
}
