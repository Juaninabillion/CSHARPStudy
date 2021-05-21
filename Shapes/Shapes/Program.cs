using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle("circle");
            Hexagon h = new Hexagon("hex");
 

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            foreach (Shape e in myShapes)
            {
                e.Draw();
            }
            Console.ReadLine();

            object[] stuff = { new Hexagon(), "test","test1",new Circle() };

            foreach (Object o in stuff)
            {
                Shape s = o as Shape;
                Hexagon h1 = o as Hexagon;
                Console.WriteLine($"{s} is s and {h1} is h1");

            }
            Console.ReadLine();
        

                    


        }
    }
}
