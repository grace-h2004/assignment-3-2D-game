// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Vector2 position;
        Vector2 velocity;
        float radius = 35;

        Color balloonColor = new Color(191, 3, 3);
        Color sky = new Color(0, 250, 255);
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Balloon Dodge");
            Window.SetSize(800, 600);

            // Set up variables once game is ready
            position = new(Window.Width / 4, 50);
         
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Reset background
            Window.ClearBackground(sky);

            // Run game logic
            ApplyGravity();
            ConstrainBalloonToScreen();

            //gen draw config
            Draw.LineColor = Color.Black;
            Draw.LineSize = 1;   

            //draw balloon
            Draw.FillColor = balloonColor;
            Draw.Ellipse(position.X, position.Y, 60, 60);
            
        }
        void ApplyGravity()
        {
            // Apply gravity to velocity
            velocity += new Vector2(0, 10) * Time.DeltaTime;
            // Apply velocity to position
            position += velocity;
        }

        void ConstrainBalloonToScreen()
        {
            // Is bottom of ball at or past edge of screen
            if (position.Y + radius >= Window.Height)
            {
                // Inverse Y velocity, move upwards
                velocity.Y = -velocity.Y;
                // Slow down velocity
                velocity *= 0.8f; // retain 80% of velocity
                // Place ball against bottom edge of screen
                position.Y = Window.Height - radius;
            }
        }
    }

}
