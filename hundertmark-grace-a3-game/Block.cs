using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Block
    {
        //                     changing Y
        public Vector2 size = new Vector2(20, 0);
        public Vector2 position;
        public int gap;
        float speed = 2;
        

        public Block(Vector2 position, int gap) 
        { 
            this.position = position;
            this.gap = gap;
        }

        public void Update()
        {
            DrawBlock();
            Movement();
        }
        public void DrawBlock()
        {
            Draw.FillColor = Color.Black;

            Draw.Rectangle(position, size);
            Draw.Rectangle(position.X, size.Y + gap, size.X, 600);
          
        }

        public void Movement()
        {
            position.X -= speed;
        }
    }
}
