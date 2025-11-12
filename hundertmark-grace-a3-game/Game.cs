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

        Block blocks = new Block();
        Vector3[] positions =
        [
            new Vector3()
        ];

        Color sky = new Color(0, 250, 255);

        int[] radii;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Balloon Dodge");
            Window.SetSize(800, 600);

            radii = new int[positions.Length];
            for (int i = 0; i < radii.Length; i++)
            {
                radii[i] = Random.Integer(10, 50);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Reset background
            Window.ClearBackground(sky);

            balloon.DrawBalloon();

            blocks.DrawBlock();



        }
        
    }

}
