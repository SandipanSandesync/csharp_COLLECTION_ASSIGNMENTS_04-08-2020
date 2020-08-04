using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListDemo_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> llist = new LinkedList<string>(new string[] { "Csharp","better","javascript",});
           
            Console.WriteLine("*******Display the linked list********");

            //llist.AddBefore(llist.Find("the"), "over");
            llist.AddFirst("The");
            llist.AddAfter(llist.Find("The"), "Language");

            llist.AddLast("Language");
            llist.AddAfter(llist.Find("Csharp"), "is");
            llist.AddBefore(llist.FindLast("javascript"), "than");
            llist.Remove("The");
            llist.AddBefore(llist.Find("Language"), "The");
            llist.RemoveFirst();
            llist.RemoveLast();

            Console.WriteLine("last node is :{0}",llist.Last.Value) ;
            Console.WriteLine("First node is :{0}", llist.First.Value);
            string[] myArr = new string[llist.Count];
            llist.CopyTo(myArr, 0);
            Console.WriteLine("After copying :");
            foreach (var item in myArr)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Displaying using getenumerator");
            LinkedList<string>.Enumerator le = llist.GetEnumerator();
            while (le.MoveNext())
            {
                Console.WriteLine(le.Current);
            }
         

            Console.Read();
            
        }
    }
}
