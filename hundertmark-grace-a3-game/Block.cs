using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Block
    {
        public Block() { }

        public Block(Vector3 position) { }

        public static Vector3 Vector3(Vector3 min, Vector3 max)
        {
            int i = 0; i < 
        }

        public void DrawBlock()
        {
            Draw.FillColor = Color.Black;

            Draw.Quad(600, 0, 700, 0, 600, 300, 700, 300);
        }
    }
}
