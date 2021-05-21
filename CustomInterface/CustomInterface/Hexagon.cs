using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Hexagon : Shape,IPointy,IDraw3d
    {
        public Hexagon() { }
        public Hexagon(string Name) : base(Name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
        public byte Points
        {
            get { return 6; }
        }
        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }
    }
}
