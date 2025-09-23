using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SierraOS.Commands
{
    internal class open :Command
    {
        public open(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                return "Error: open requires an argument.";
            }

            else
            {
                try
                {
                    string content = File.ReadAllText(args[0]);
                    Console.WriteLine("\n");
                    Console.WriteLine(content);
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("Error: " + exeption.Message);
                }
            }

              

            return "";

        }

      
        
    }
}
