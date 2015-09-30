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
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Cat", 1);
            dictionary.Add("Dog", 2);
            dictionary.Add("Icama", 0);
            dictionary.Add("Iguana", -1);
            //dictionary.Add(1, -2); //not allowed

            /*  Hashtable
             *  1.Return null if you try to access a key which does not exist.
             *  2.Slower than dictionary because it requires boxing and unboxing
             *  3.Non-generic
             */ 

            /*  Dictionary
             *  1. return error for the same situation
             *  2. Faster than hashtable, no boxing, unboxing behind the scene.
             *  3. Generic
             */
        }
    }
}
