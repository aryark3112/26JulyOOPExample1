using System;

namespace OOPExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassName objectName= new ClassName();
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            Console.WriteLine("Enter Employee One Details");
            employee.Register();
            Console.WriteLine("Enter Employee Two Details");
            employee2.Register();
            Console.WriteLine("Employee One Display");
            employee.Display();
            Console.WriteLine("Employee Two Display");
            employee2.Display();
            Console.ReadKey();
        }
    }
}
