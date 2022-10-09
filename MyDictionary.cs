using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<T,Y>
    {
        KeyValuePair<T, Y>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<T, Y>[0];
        }

        public int Count { get {return items.Length; } }
        public void Add(T key,Y value)
        {
            KeyValuePair<T, Y>[] tempArray = items;
            items = new KeyValuePair<T, Y>[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = new KeyValuePair<T, Y>(key,value); 
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key +"-"+item.Value);
            }
        }

    }
}
