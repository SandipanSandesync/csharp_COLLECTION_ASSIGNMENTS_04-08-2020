using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListDemo_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sortedlist = new SortedList<string, string>();
            sortedlist.Add("India", "MSDhoni");
            sortedlist.Add("Australia", "RickyPonting");
            sortedlist.Add("England", "KevinPeterson");
            sortedlist.Add("Newzealand", "Williamson");
            sortedlist.Add("SouthAfrica", "ABDvillers");
            Console.WriteLine("************Displaying the sorted list************");
            foreach (var item in sortedlist)
            {
                Console.WriteLine("{0} : {1}",item.Key,item.Value);
            }
            Console.WriteLine("*******Remove******");
            sortedlist.Remove("England");
            Console.WriteLine("list after removing");
            foreach(var item in sortedlist)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

           sortedlist.Add("England", "KevinPeterson");
            Console.WriteLine("********Index of key*******");
            Console.WriteLine(  "Index of key india is :{0}" ,sortedlist.IndexOfKey("India"));
            Console.WriteLine("************Index of value**********");
            Console.WriteLine("Index of key SouthAfrica is :{0}", sortedlist.IndexOfKey("SouthAfrica"));

            Console.WriteLine("********containskey*********");
            if(sortedlist.ContainsKey("India"))
            {
                Console.WriteLine("Present in list");
            }
            else
            {
                Console.WriteLine("not present");
            }
            Console.WriteLine("******containsvalue********");
            if(sortedlist.ContainsValue("MSDhoni"))
            {
                Console.WriteLine("Present in list");
            }
            else
            {
                Console.WriteLine("not present");
            }
            Console.WriteLine("***********Get Value*********");
            Console.WriteLine( sortedlist.TryGetValue("India", out _));
            Console.WriteLine("***********Remove at*********");
            sortedlist.RemoveAt(3);
            Console.WriteLine("after removing 4th index");
            foreach (var item in sortedlist)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
           
            IEnumerator<KeyValuePair<string, string>> ie = sortedlist.GetEnumerator();
            Console.WriteLine("Display");
            while (ie.MoveNext())
            {
                Console.WriteLine("{0} : {1}", ie.Current.Key,ie.Current.Value);
            }
           // sortedlist.GetEnumerator

            Console.Read();
        }
    }
}
