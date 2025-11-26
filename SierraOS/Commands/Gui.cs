using System;
using System.Drawing;
using System.Threading;
using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;

namespace SierraOS.Commands
{
    public class Gui : Command
    {
        Canvas canvas;
        private int screenWidth = 640;
        private int screenHeight = 480;
        private bool running = true;

        public Gui(string name) : base(name) { }

        public override string execute(string[] args)
        {
            System.Console.WriteLine("Please choose a resolution to display:\n1. 1920x1080 (16:9)\n2. 1280x720 (16:9)\n3. 800x600 (4:3)\n4. 640x480 (4:3)");
            ConsoleKeyInfo keyInfo = System.Console.ReadKey();
            char keyPressed = keyInfo.KeyChar;

            if (keyPressed == '1')
            {
                screenWidth = 1920;
                screenHeight = 1080;
            }
            else if (keyPressed == '2')
            {
                screenWidth = 1280;
                screenHeight = 720;
            }
            else if (keyPressed == '3')
            {
                screenWidth = 800;
                screenHeight = 600;
            }
            else if (keyPressed == '4')
            {
                screenWidth = 640;
                screenHeight = 480;
            }           
            else
            {
                System.Console.WriteLine("Invalid, using 640x480");
                screenWidth = 480;
                screenHeight = 360;
                Thread.Sleep(2000);
            }

            RunGUI();
                    return "";
            
        }

        private void RunGUI()
        {
            System.Console.WriteLine($"Starting GUI in {screenWidth}x{screenHeight}");
            try
            {
                canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(screenWidth, screenHeight, ColorDepth.ColorDepth32));
            }
            catch (Exception ex)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"\nFailed to set mode {screenWidth}x{screenHeight}: {ex.Message}");
                System.Console.ResetColor();
            }
            MouseManager.ScreenWidth = (uint)screenWidth;
            MouseManager.ScreenHeight = (uint)screenHeight;
            MouseManager.X = (uint)(screenWidth / 2);
            MouseManager.Y = (uint)(screenHeight / 2);
            running = true;
            while (running)
            {
                canvas.Clear(Color.Blue);
                int mouseX = (int)MouseManager.X;
                int mouseY = (int)MouseManager.Y;
                DrawCursor(mouseX, mouseY);canvas.DrawString($"X: {mouseX} Y: {mouseY}",PCScreenFont.Default,new Cosmos.System.Graphics.Pen(Color.Yellow),10, 10);
                canvas.Display();
                Thread.Sleep(10);
            }
        }

        private void DrawCursor(int x, int y)
        {
            int size = 8;
            canvas.DrawFilledRectangle(new Cosmos.System.Graphics.Pen(Color.White),x, y, size, size);
        }
    }
}
