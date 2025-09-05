using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Help : Command
    {
        public Help(string name) : base(name) { }

        public override string execute(string[] args)
        {
            helpStuff();
            return "";
        }

        public static void helpStuff()
        {
            Console.Write("\nhelp          Lists Commands");
            Console.Write("\nabout         About SierraOS");
            Console.Write("\nver           Displays the SierraOS version");
            Console.Write("\nclear         Clears the screen");
            Console.Write("\ncolour        Change the background and foreground colours");
            Console.Write("\nlist          Lists all files in a directory");
            Console.Write("\nvfs           Sets up the Virtual File System");
            Console.Write("\nopen          Displays the contents of a text file");
            Console.Write("\necho          Echos something the user types");
            Console.Write("\ntime          Displays the current system time");
            Console.Write("\ndate          Displays the current system date");
            Console.Write("\nbeep          Beeps");
            Console.Write("\ncoinflip      Flips a coin");
            Console.Write("\ndiagnostics   Diagnostic menu");
            Console.Write("\nshutdown      Shuts down SierraOS");
            Console.Write("\nreboot        Reboots SierraOS");
            Console.WriteLine();

        }
    }
}
