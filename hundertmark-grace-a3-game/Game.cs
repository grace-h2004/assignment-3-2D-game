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

        Balloon balloon = new Balloon();


        Color sky = new Color(0, 250, 255);
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Balloon Dodge");
            Window.SetSize(800, 600);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Reset background
            Window.ClearBackground(sky);

            balloon.DrawBalloon();

        }
        
    }

}
