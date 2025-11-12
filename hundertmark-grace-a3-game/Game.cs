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

        Block[] blocks =
        {
            new Block(new Vector2(800, 0), 120),
            new Block(new Vector2(1200, 0), 120)
        };

        Color sky = new Color(0, 250, 255);

        System.Random random = new System.Random();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Balloon Dodge");
            Window.SetSize(800, 600);

            for (int i = 0; i < blocks.Length; i++)
            {
                int Ysize = random.Next(0, Window.Height - blocks[i].gap);
                blocks[i].size.Y = Ysize;
            }
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Reset background
            Window.ClearBackground(sky);

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i].Update();
            }
            balloon.Update(blocks);
        }

    }

}
