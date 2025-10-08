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
        public enum Status
        {
            OK,
            WARNING,
            ERROR
        };

        // message function and fs initialization remake code originally by github user "CodeCs1" in their repo "TerminalOs-v1-C-
        public static void Message(string text, Status status)
        {
            string status_text;
            string empty = string.Empty;
            status_text = empty;
            if (status == Status.OK) status_text = "OK";
            if (status == Status.ERROR) status_text = "ERROR";
            if (status == Status.WARNING) status_text = "WARNING";

            Console.WriteLine("[" + status_text + "] " + text);
        }

        private CommandManager _commandManager;
        protected override void BeforeRun()
        {
            Console.WriteLine("OK");
            Boot.CpuVendor.cpu();
            Boot.CpuBrand.brand();
            Boot.CpuUptime.SysUptime();
            Boot.RAM.RAMStuff();
            Boot.BootTime.Time();
            Boot.BootDate.Date();
            Console.WriteLine("0.09");
            this._commandManager = new CommandManager();    
            Console.WriteLine("VFS has not been initialized yet, please do this manually");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to SierraOS");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            //Console.Clear();
            Console.WriteLine("\r\n\r\n ____  _                      ___  ____  \r\n/ ___|(_) ___ _ __ _ __ __ _ / _ \\/ ___| \r\n\\___ \\| |/ _ \\ '__| '__/ _` | | | \\___ \\ \r\n ___) | |  __/ |  | | | (_| | |_| |___) |\r\n|____/|_|\\___|_|  |_|  \\__,_|\\___/|____/ \r\n\r\n");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Would you like to log in now?\n(y/n)");
            ConsoleKeyInfo keyInput = Console.ReadKey(true);
            if (keyInput.Key == ConsoleKey.Y)
            {
                UAccount.LogIn.login();
            }
            if (keyInput.Key == ConsoleKey.M)
            {
                Thread.Sleep(400);
                Console.Clear();
            }
            else
            {
                Boot.BootChime.chime();
                Thread.Sleep(400);
                Console.Clear();
            }


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
