using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, 1200, "John", "Teacher", "Science", "Banglore");
            Console.WriteLine("Employee ID : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.WriteLine("Employee Name : " + emp[3]);
            Console.WriteLine("Employee Job: " + emp[4]);
            Console.WriteLine("Employee Dname: " + emp[5]);
            Console.WriteLine("Employee Location: " + emp[6]);
            emp[1] = 123;
            emp[2] = 13000.00;
            Console.WriteLine("Employee ID : " + emp[1]);
            Console.WriteLine("Employee Salary : " + emp[2]);
            Console.ReadLine();
        }
    }
}
