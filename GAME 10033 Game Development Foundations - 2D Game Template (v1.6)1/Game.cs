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

            // Environment
            // Blue sky
            Draw.SetFillColor(173, 216, 230);
            Draw.Rectangle(0, 0, 400, 140);

            // Green ground
            Draw.SetFillColor(0, 200, 0);
            Draw.Rectangle(0, 137, 400, 400);

            // Set line weight
            Draw.SetLineSize(2);

            // Background house
            Draw.SetFillColor(170, 10, 10);
            Draw.Square(300, 120, 25);
            // Roof
            Draw.Triangle(300, 120, 325, 120, 313, 115);

            // Cloud
            Draw.SetFillColor(255);
            Draw.SetLineColor(255);

            // Cloud Shapes
            Draw.Circle(50, 65, 40);
            Draw.Circle(95, 40, 30);
            Draw.Ellipse(100, 70, 80, 42);

            // Draws normal sheep if space not held down
            // Removes normal sheep and draws skeleton if space is held down
            // and tablet is hovering over sheep's location
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == false)
            {
                Draw.SetFillColor(Color.Black);
                // Head
                Draw.Capsule(200, 180, 220, 185, 15);
                Draw.SetFillColor(Color.White);
                Draw.Circle(210, 182, 5);

                // Legs
                Draw.SetFillColor(Color.Black);
                Draw.Quad(250, 230, 270, 230, 270, 240, 250, 240);
                Draw.Quad(290, 230, 310, 230, 310, 240, 290, 240);

                // Body
                Draw.SetFillColor(Color.White);
                Draw.Circle(270, 188, 45);

            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true && Input.GetMouseX() >= 150 && Input.GetMouseY() >= 180 && Input.GetMouseX() <= 278 && Input.GetMouseY() <= 240)
            {
                Draw.SetFillColor(Color.White);
                // Skull
                Draw.Capsule(200, 180, 220, 185, 15);
                Draw.SetFillColor(Color.Black);
                Draw.Circle(210, 182, 5);
                // Bones
                Draw.SetFillColor(Color.White);
                Draw.Line(220, 180, 300, 175);
                Draw.Line(220, 180, 250, 230);
                Draw.Line(290, 175, 290, 230);

                // Legs

                Draw.SetFillColor(Color.White);
                Draw.Quad(250, 230, 270, 230, 270, 240, 250, 240);
                Draw.Quad(290, 230, 310, 230, 310, 240, 290, 240);

            }

            // Four silver rectangles drawn relative to mouse location
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

            // Silver rectangle further right for depth
            Draw.SetFillColor(192, 192, 192);
            Draw.Rectangle(Input.GetMouseX() + 95, Input.GetMouseY() - 50, 5, 95);

            // Draw two circles atop right silver rectangle
            // Both colors and screen change with spacebar click
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space))
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

                // Rectangle is transparent with black outline
                Draw.SetFillColor(0, 0, 0, 0);
                Draw.SetLineColor(0);
                Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() - 40, 125, 75);
            }

            else
            {
                // Top button black, bottom red
                // Top
                Draw.SetFillColor(0, 0, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 30, 10);

                // Bottom
                Draw.SetFillColor(200, 0, 0);
                Draw.SetLineColor(0);
                Draw.Circle(Input.GetMouseX() + 80, Input.GetMouseY() - 5, 10);

                // Rectangle is lavender with black outline
                Draw.SetFillColor(230, 230, 250);
                Draw.SetLineColor(0);
                Draw.Rectangle(Input.GetMouseX() - 60, Input.GetMouseY() - 40, 125, 75);
            }
        }
    }
}