using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample1
{
    //[A.S.] [Modifier] class <ClassName>:[Base ClassName][Interface]
    //{
    //Members of the class
    //fields
    //properties
    //constructor
    //methods
    //indexer
    //events
    //delegates
    //}
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
            id = -1;
            name = "not given";
        }
        public void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Name: " + name);
        }
    }
}
