using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(new Car.CarEgineHandler(onCarEngineEvent));
            c1.RegisterWithCarEngine(new Car.CarEgineHandler(testing));

            Console.WriteLine("**** Speeding up****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }
        public static void onCarEngineEvent(string msg)
        {
            Console.WriteLine("\n****** Messag From Car PObject ****");
            Console.WriteLine($"+> {msg}");
            Console.WriteLine("\n************************************");
        }

        public static void testing(string msg)
        {
            Console.WriteLine("\n this is the message but from another method {0}",msg);
        }
    }
}
