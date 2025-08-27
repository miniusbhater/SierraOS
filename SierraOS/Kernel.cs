using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
namespace SierraOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to SierraOS");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("\r\n\r\n ____  _                      ___  ____  \r\n/ ___|(_) ___ _ __ _ __ __ _ / _ \\/ ___| \r\n\\___ \\| |/ _ \\ '__| '__/ _` | | | \\___ \\ \r\n ___) | |  __/ |  | | | (_| | |_| |___) |\r\n|____/|_|\\___|_|  |_|  \\__,_|\\___/|____/ \r\n\r\n");
            Console.Beep();
            Thread.Sleep(1500);            
            Console.Clear();
        }

        protected override void Run()
        {          
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
            
        }

    }
}
