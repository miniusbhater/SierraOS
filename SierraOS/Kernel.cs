using Cosmos.Core;
using Cosmos.Core.Memory;
using SierraOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;
using Cosmos.HAL;



namespace SierraOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager _commandManager;
        protected override void BeforeRun()
        {
            Console.WriteLine("OK");
            Console.Beep();
            Boot.CpuVendor.cpu();
            Boot.CpuBrand.brand();
            Boot.CpuUptime.SysUptime();
            Boot.RAM.RAMStuff();
            Boot.BootTime.Time();
            Boot.BootDate.Date();
            Console.WriteLine("0.05");
            this._commandManager = new CommandManager();    
            Console.WriteLine("VFS has not been initialized yet, please do this manually");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to SierraOS");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            //Console.Clear();
            Console.WriteLine("\r\n\r\n ____  _                      ___  ____  \r\n/ ___|(_) ___ _ __ _ __ __ _ / _ \\/ ___| \r\n\\___ \\| |/ _ \\ '__| '__/ _` | | | \\___ \\ \r\n ___) | |  __/ |  | | | (_| | |_| |___) |\r\n|____/|_|\\___|_|  |_|  \\__,_|\\___/|____/ \r\n\r\n");
            Thread.Sleep(300);
            Boot.BootChime.chime();
            Thread.Sleep(4000);         
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
