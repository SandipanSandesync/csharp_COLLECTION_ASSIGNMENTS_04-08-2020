using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentListGenericMethodsExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Using a generic collection list similar to arraylist************");
            List<int> li = new List<int>();
            li.Add(51);
            li.Add(7);
            li.Add(87);
            li.Add(78);
            li.Add(89);
            li.Add(75);
            li.Add(78);
            Console.WriteLine("**********FIND METHOD***********");
            int findRes = li.Find(x => x.Equals(12));
            Console.WriteLine("Finding 12 in the list :{0}", findRes);
            foreach (int i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********findAll Method*******");
            List<int> findAllRes = li.FindAll(x => x.Equals(78));
            Console.WriteLine("Finding all elements as 78 :");
            foreach(var item in findAllRes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********FindIndex Method*************");
            int findIndex = li.FindIndex(x => x.Equals(78));
            Console.WriteLine("Finding indexes of 78 :");
            Console.WriteLine(findIndex);
            Console.WriteLine("***********FindLast Method************");

            int findLast = li.FindLast(x => x.Equals(78));
            Console.WriteLine("Last element quals to 78 is :{0}",findLast);
            Console.WriteLine("********FindLastIndex Method*********");
            int findlastindex=li.FindLastIndex(x => x.Equals(78));
            Console.WriteLine(findlastindex);
            Console.Read();
        }
    }
}
