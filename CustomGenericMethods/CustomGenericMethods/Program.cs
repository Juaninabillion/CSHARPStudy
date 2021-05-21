using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap two ints
            int a = 10, b = 90;

            Console.WriteLine($"Before swap: {a} , {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swap : {a} , {b}");
            Console.WriteLine();

            // Swap Two Strings
            string s1 = "hello", s2 = "There";
            Console.WriteLine($"Before Swap : {s1}, {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swap : {s2} , {s1}");
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}",typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;

        }

    }
}
