using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsAssignmetArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection coll = new int[] { 6, 7, 8, 9 };

            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.AddRange(coll);
            arr.Insert(0, 4);
            Console.WriteLine("Elements of arraylist :");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Capacity :{0}", arr.Capacity);
            ArrayList objClone = (ArrayList)arr.Clone();
            Console.WriteLine("Array list after cloning :");
            foreach (var v in objClone)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Count array elements :{0}", arr.Count);
            Console.WriteLine("Index of 4 :{0}", arr.IndexOf(4));
            Console.WriteLine("last index of  8 :{0}", arr.LastIndexOf(8));
            Console.WriteLine("Inserting 3 in 1st position :");
            arr.Insert(0, 3);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Inserting a range of array in arr :");
            ICollection ic = new int[] { 10, 11, 12, 13 };
            arr.InsertRange(7, ic);
            foreach (var f in arr)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Copying element to another array :");
            ArrayList arr1 = new ArrayList();
            Array a1 = new int[arr.Count];
            arr.CopyTo(a1);
            Console.WriteLine("New array :");
            foreach (var k in a1)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("After remove 3 from arr:");
            arr.Remove(3);
            foreach (var v in arr)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Remove at index no 5 element is 9:");
            arr.RemoveAt(5);
            foreach (var q in arr)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("Remove a range of an array :");
            arr.RemoveRange(6, 3);
            foreach (var o in arr)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Reversing a array :");
            arr.Reverse();
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("After sorting :");
            arr.Sort();
            foreach (var l in arr)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("Get a range of array from index 3");
            ArrayList get = arr.GetRange(3, 2);
            foreach (var z in get)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine("Contain method :");
            if (arr.Contains(8))
            {
                Console.WriteLine("8 is present");
            }
            else
            {
                Console.WriteLine("not present");
            }
            Console.WriteLine("After clear methods arraylist");
            arr.Clear();
            Console.WriteLine("no array list");
            Console.Read();
        }
    }
}
