using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class Commandss : Command
    {
        public Commandss(string name) : base(name) { }

        public override string execute(string[] args)
        {
            commandsStuff();
            return "";
        }

        public static void commandsStuff()
        {
            Console.Write("\nabout");
            Console.Write("\naccount");
            Console.Write("\nbeep");
            Console.Write("\nclear");
            Console.Write("\ncoinflip");
            Console.Write("\ncolour");
            Console.Write("\ncommands");
            Console.Write("\ndate");
            Console.Write("\ndiagnostics");
            Console.Write("\necho");
            Console.Write("\ngithub");
            Console.Write("\nhelp");
            Console.Write("\nlist");
            Console.Write("\nopen");
            Console.Write("\nreboot");
            Console.Write("\nvfs");
            Console.Write("\nshutdown");
            Console.Write("\nstrobe");
            Console.Write("\ntime");
            Console.Write("\nuptime");
            Console.Write("\nver");
            Console.WriteLine();

        }
    }
}
