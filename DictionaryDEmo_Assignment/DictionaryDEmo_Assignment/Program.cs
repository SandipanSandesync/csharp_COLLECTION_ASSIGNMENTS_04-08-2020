using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDEmo_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "one");
            dt.Add(2, "two");
            dt.Add(3, "three");
            dt.Add(4, "four");
            dt.Add(5, "five");
            dt.Add(6, "six");
            Dictionary<int, string>.Enumerator en = dt.GetEnumerator();
            Console.WriteLine("******Display using getenumerator*********");
            while (en.MoveNext())
            {
                Console.WriteLine("{0} : {1}", en.Current.Key, en.Current.Value);
            }
            Console.WriteLine("*******Remove******");
            dt.Remove(4);
            Console.WriteLine("list after removing");
            foreach (var item in dt)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.WriteLine("********containskey*********");
            if (dt.ContainsKey(3))
            {
                Console.WriteLine("Present in list");
            }
            else
            {
                Console.WriteLine("not present");
            }
            Console.WriteLine("********containsValue*********");
            if (dt.ContainsValue("three"))
            {
                Console.WriteLine("Present in list");
            }
            else
            {
                Console.WriteLine("not present");
            }
            Console.WriteLine("dictionary count is  :{0}",dt.Count);
            


            Console.Read();


        }
    }
}
