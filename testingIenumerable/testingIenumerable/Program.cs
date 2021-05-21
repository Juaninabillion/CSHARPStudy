using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingIenumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var array = new int[] { 1, 2, 3,55,5,5,5,5,5,5 };

            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");
            }

            array.GetEnumerator();
            var enumerator = array.GetEnumerator();
            enumerator.MoveNext();
            enumerator.MoveNext();
            enumerator.MoveNext();
            enumerator.MoveNext();



            Console.WriteLine(enumerator.Current);
            Console.ReadLine();
        }
    }
}
