using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle:Circle,IDraw3d
    {
        public void Draw3D()
        {
            Console.WriteLine("Darwing Circle in 3D");
        }
    }
}
