using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D

{
    public class Balloon
    {
        //variables
        
        public Vector2 position;
        public Vector2 velocity;
        public float radius = 35;

        Color balloonColor = new Color(191, 3, 3);

        bool badEnd = false;

        public Balloon() {
            // Set up variables once game is ready
            position = new(Window.Width / 1, 50);

            
        }

        public Balloon(Vector2 position) 
        {  
            this.position = position; 
        }

        


        public void DrawBalloon()
        {
            //gen draw config
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;

            //draw balloon
            Draw.FillColor = balloonColor;
            Draw.Ellipse(position.X, position.Y, 60, 60);

            if(badEnd == true)
            {
                Window.ClearBackground(Color.Red);
            }
        }
        public void Update(Block[] blocks)
        {
            DrawBalloon();
            ApplyGravity();
            ConstrainBalloonToScreen();
            GetPlayerInput();
            Collision(blocks);
        }
        void ApplyGravity()
        {
            velocity += new Vector2(0, 400) * Time.DeltaTime;
            position += velocity * Time.DeltaTime;
        }
        void ConstrainBalloonToScreen()
        {
            if (position.Y + radius >= Window.Height)
            {
                velocity.Y = -velocity.Y;
                velocity *= 0.8f;
                position.Y = Window.Height - radius;
            }
        }

        void GetPlayerInput()
        {
           
                        // balloon move up
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                velocity.Y = -200;
            }
            
        }

        void Collision(Block[] blocks)
        {
            float playerTop = position.Y;
            float playerBottom = position.Y + radius;
            float playerLeft = position.X;
            float playerRight = position.X + radius;
            //hit box collision
            for (int i = 0; i < blocks.Length; i++)
            {
                Block block = blocks[i];

                float blockTop = block.position.Y;
                float blockBottom = block.position.Y + block.size.Y;
                float blockLeft = block.position.X;
                float blockRight = block.position.X + block.size.X;

                float bottomBlockTop = block.size.Y + block.gap;
                float bottomBlockBottom = block.size.Y + block.gap + 600;
                float bottomBlockLeft = block.position.X;
                float bottomBlockRight = block.position.X + block.size.X;

                bool isColliding = false;
                if(playerRight > blockLeft && playerLeft < blockRight && playerBottom > blockTop && playerTop < blockBottom)
                {
                    isColliding = true;
                }
                if (playerRight > bottomBlockLeft && playerLeft < bottomBlockRight && playerBottom > bottomBlockTop && playerTop < bottomBlockBottom)
                {
                    isColliding = true;
                }
                if (isColliding)
                {
                    //end game bad
                    badEnd = true;
                }
            }
        }
    }
}
