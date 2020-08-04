using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPersonAssignment
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;

        }
        public void DisplayPerson()
        {
            Console.WriteLine("********PERSONAL DETAILS************");
            Console.WriteLine("Age :{0}",age);
            Console.WriteLine("First Name :{0}",fname);
            Console.WriteLine("Last Name  :{0}",lname);
            Console.WriteLine("City :{0}",city);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(22, "Sandipan", "Ghosh", "Kolkata");

            List<Person> per = new List<Person>();
            per.Add(p);

            foreach (var item in per)
            {
                item.DisplayPerson();

            }
            //Console.WriteLine(per);
            Console.Read();
            

        }
    }
}
