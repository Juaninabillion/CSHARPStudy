using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with system.object");

            Person p1 = new Person();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p1.GetType());
                Console.ReadLine();
                
        }
    }
}
