using Cosmos.Core.Memory;
using SierraOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace SierraOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager _commandManager;
        protected override void BeforeRun()
        {
            this._commandManager = new CommandManager();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to SierraOS");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            //Console.Clear();
            Console.WriteLine("\r\n\r\n ____  _                      ___  ____  \r\n/ ___|(_) ___ _ __ _ __ __ _ / _ \\/ ___| \r\n\\___ \\| |/ _ \\ '__| '__/ _` | | | \\___ \\ \r\n ___) | |  __/ |  | | | (_| | |_| |___) |\r\n|____/|_|\\___|_|  |_|  \\__,_|\\___/|____/ \r\n\r\n");
            Console.Beep();
            Thread.Sleep(1500);            
            Console.Clear();

        }

        protected override void Run()
        {
            Console.Write(@"> ");
            string response;
            string input = Console.ReadLine();
            response = this._commandManager.processInput(input);
            Console.WriteLine(response);
            
        }

    }
}
