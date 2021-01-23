using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> acer = new Dictionary<int, string>();
            acer.Add(1 , "okey");
            Console.WriteLine(acer.Values.Count);
        }

        class MyDictionary<K , V>
        {
            K[] arrayKey;
            V[] arrayValue;
            
            public MyDictionary()
            {
                arrayKey = new K[0];
                arrayValue = new V[0];
            }
            
            public void Add(K key, V value)
            {
                K[] tempKey = arrayKey;
                V[] tempValue = arrayValue;

                arrayKey = new K[arrayKey.Length + 1];
                arrayValue = new V[arrayValue.Length + 1];

                for (int i = 0; i < tempKey.Length; i++)
                {
                    arrayKey[i] = tempKey[i];
                    arrayValue[i] = tempValue[i] ;
                }

                arrayKey[arrayKey.Length - 1] = key;
                arrayValue[arrayValue.Length - 1] = value;
            }
        }
    }
}
