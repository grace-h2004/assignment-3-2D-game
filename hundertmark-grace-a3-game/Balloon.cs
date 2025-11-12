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
            
           
            // Run game logic
            ApplyGravity();
            ConstrainBalloonToScreen();

            //gen draw config
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;

            //draw balloon
            Draw.FillColor = balloonColor;
            Draw.Ellipse(position.X, position.Y, 60, 60);

            GetPlayerInput();

        }

        void ApplyGravity()
        {
            velocity += new Vector2(0, 10) * Time.DeltaTime;
            position += velocity;
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
            
            Vector2 input = Vector2.Zero;
                        // balloon move up
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                input.Y -= 2;
                
            }
            
        }


    }
}
