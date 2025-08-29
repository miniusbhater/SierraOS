using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Colour : Command
    {
        public Colour(string name) : base(name) { }

        public override string execute(string[] args)
        {
            ColourMenu();
            return "";

        }

        public void ColourMenu()
        {
            Console.Clear();
            string input;
            Console.WriteLine("1. Background colour\n2. Foreground colour");
            input = Console.ReadLine();
            if (input == "1")
            {
                Background();
            }
            if (input == "2")
            {
                Foreground();
            }
        }

        public void Background()
        {
            string input;
            Console.WriteLine("1. Black\n2. White\n3. Red\n4. Blue\n5. Green\n6. Yellow\n7. Magenta\n8. Cyan");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "7":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "8":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            ColourMenu();
        }

        public void Foreground()
        {
            string input;
            Console.WriteLine("1. Black\n2. White\n3. Red\n4. Blue\n5. Green\n6. Yellow\n7. Magenta\n8. Cyan");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "7":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "8":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            ColourMenu();
        }
    }
}
