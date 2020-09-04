using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            Employee emp = new Employee("Juan Alban", 1 , 2.5f);
            emp.DisplayStats();
            emp.Name = "Mary";
            emp.Pay = 200;
            emp.GiveBonus(400);
            emp.DisplayStats();

            Console.ReadLine();

             



        }
    }
}
