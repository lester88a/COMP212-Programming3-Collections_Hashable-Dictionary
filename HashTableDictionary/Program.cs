using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                 Collections
             * 
             * Hash Table > Non-Generic[not type safe] > using system.collections;
             * Dictionary > generic >[type-safe] > using system.collections.generic;
             * 
             * Hash Table & Dictionary are collections > they need (key, value) perimeter
             */
            //Hash table
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            int value = (int)hashtable["Area"];
            hashtable.Add(55, "li xu");

            //Dictionary

        }
    }
}
