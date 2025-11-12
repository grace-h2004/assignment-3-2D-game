// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        //calls button
        Button titleScreenButton = new Button(new Vector2(350, 400), new Vector2(100, 60), new string("PLAY"));
        //calls balloon
        Balloon balloon = new Balloon();
        //calls blocks
        Block[] blocks =
        {
            new Block(new Vector2(800, 0), 120),
            new Block(new Vector2(1200, 0), 120),
            new Block(new Vector2(1500, 0), 120),
            new Block(new Vector2(1690, 0), 120),
            new Block(new Vector2(1830, 0), 120),
            new Block(new Vector2(2000, 0), 120),
            new Block(new Vector2(2190, 0), 120),
            new Block(new Vector2(2310, 0), 120),
            new Block(new Vector2(2430, 0), 120),
            new Block(new Vector2(2500, 0), 120),
            new Block(new Vector2(2620, 0), 120),
            new Block(new Vector2(2710, 0), 120),
        };

        //new colors
        Color sky = new Color(0, 250, 255);

        //adds randomness for blocks
        System.Random random = new System.Random();
        //calls titlescreen
        bool titleScreen = true;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //general config
            Window.SetTitle("Balloon Dodge");
            Window.SetSize(800, 600);

            //integer for block apperence
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
            // set background
            Window.ClearBackground(sky);

            //make title screen
            if (titleScreen == true)
            {
                titleScreenButton.Update();
                if(titleScreenButton.MouseClick())
                { 
                    titleScreen = false;                
                }
            }
            if (titleScreen == false)
            {

                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i].Update();
                }
                balloon.Update(blocks);
            }
            

        }

    }

}
