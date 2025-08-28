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
            if (input == "1")
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (input == "2")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            if (input == "3")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (input == "4")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (input == "5")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (input == "6")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (input == "7")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (input == "8")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            ColourMenu();
        }

        public void Foreground()
        {
            string input;
            Console.WriteLine("1. Black\n2. White\n3. Red\n4. Blue\n5. Green\n6. Yellow\n7. Magenta\n8. Cyan");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (input == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (input == "4")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (input == "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (input == "6")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (input == "7")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            if (input == "8")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            ColourMenu();
        }
       

    }
}
