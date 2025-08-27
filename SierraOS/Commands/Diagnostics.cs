using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SierraOS.Commands
{
    public class Diagnostics : Command
    {
        public Diagnostics(string name) : base(name) { }

        public override string execute(string[] args)
        {
            DiagMenu();
            return "";

        }

        public void DiagMenu()
        {
            string input;
            Console.WriteLine("1. Display\n2. Sound");
            input = Console.ReadLine();
            if (input == "1")
            {
                Display();
            }
            if (input == "2")
            {
                sound();
            }
        
            }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Display will cycle colours changing every 5 seconds");
            Thread.Sleep(5000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Display test complete returning in 5 seconds");
            Thread.Sleep(5000);
            Console.Clear();
            DiagMenu();
        }

        public void sound() 
        {
            Console.Clear();
            Console.WriteLine("SierraOS will play 6 beeps");
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(3000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Beep();
            Thread.Sleep(1000);
            Console.Clear();
            DiagMenu();
        }
    }
}
