// Include the namespaces (code libraries) you need below.
using System;
using System.Net.Security;
using System.Numerics;
using Raylib_cs;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("X-Ray Farmer");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Keeps background off-white
            Window.ClearBackground(255);

            // Four silver rectangles drawn relative to mouse location
            // Silver border lavender rectangle
            // Above
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() - 50, 125, 10);

            // Below
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() + 35, 125, 10);

            // Left
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() - 70, Input.GetMouseY() - 50, 10, 95);

            // Right
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() + 65, Input.GetMouseY() - 50, 30, 95);

            // Silver rectangle further right to give depth
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() + 95, Input.GetMouseY() - 50, 5, 95);


            // Draw two circles atop right silver rectangle
            // Both colors change with spacebar click
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                // Top button green, bottom black
                // Top
                Draw.SetFillColor(0, 100, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 30, 10);

                // Bottom
                Draw.SetFillColor(0, 0, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 5, 10);
            }

            else
            {
                // Top button black, bottom red
                // Top
                Draw.SetFillColor(0, 0, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 30, 10);

                // Bottom
                Draw.SetFillColor(100, 0, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 5, 10);

            }

            // Draws rectangle centered on mouse location, color dependent on spacebar click
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                // Rectangle is transparent with black outline
                Draw.SetFillColor(0, 0, 0, 0);
                Draw.SetLineColor(0);
                Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() - 40, 125, 75);
            }

            else
            {
                // Rectangle is lavender with black outline
                Draw.SetFillColor(230, 230, 250);
                Draw.SetLineColor(0);
                Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() - 40, 125, 75);
            }

        }
    }

}
