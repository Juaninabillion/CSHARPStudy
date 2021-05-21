using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Fin with interfaces \n");
            // Call Points propertydefined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            Console.ReadLine();

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


            Hexagon hex2 = new Hexagon("Peter");

            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");
            Console.ReadLine();
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle(" Joe"), new Circle(" JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                }
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                Console.WriteLine();


                Console.WriteLine("Looking for idraw interface now as a parameter");
                if (myShapes[i] is IDraw3d)
                {
                    Console.WriteLine("I made it here ");
                    DrawIn3D((IDraw3d)myShapes[i]);
                }
            }
            Console.ReadLine();

        }
        static void DrawIn3D(IDraw3d itf3d)
        {
            Console.WriteLine("-> Drawing Idraw3D compatible type");
            itf3d.Draw3D();
        }
    }
}

