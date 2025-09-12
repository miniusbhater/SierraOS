using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class About : Command
    {
        public About(string name) : base(name) { }

        public override string execute(string[] args)
        {
            AboutPrint();
            return "";

        }

        public void AboutPrint()
        {
            Console.WriteLine("\r\n\r\n ____  _                      ___  ____  \r\n/ ___|(_) ___ _ __ _ __ __ _ / _ \\/ ___| \r\n\\___ \\| |/ _ \\ '__| '__/ _` | | | \\___ \\ \r\n ___) | |  __/ |  | | | (_| | |_| |___) |\r\n|____/|_|\\___|_|  |_|  \\__,_|\\___/|____/ \r\n\r\n");
            Console.WriteLine("0.08");
            Console.WriteLine("12/09/2025");
            Console.WriteLine("Made by miniusbhater and Adam1000");
        }
    }
}
