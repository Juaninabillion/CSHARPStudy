using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExecption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTune(true);

            try{
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Messages: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.ReadLine();
            }
        }
    }
}
