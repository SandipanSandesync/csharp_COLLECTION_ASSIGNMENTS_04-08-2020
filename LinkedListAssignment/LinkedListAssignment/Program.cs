using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListAssignment
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            LinkedList<string> llist = new LinkedList<string>(new string[] { "quick", "fox", "the", "lazy" });
            llist.AddBefore(llist.Find("the"), "over");
            llist.AddFirst("the");
           llist.AddLast("fox");
            llist.AddAfter(llist.Find("quick"), "brown");
            llist.AddBefore(llist.FindLast("over"), "jumps");
            
           
            Console.WriteLine(llist);
            foreach(var item in llist)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
