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
            openfile();
            return "";

        }

        public void openfile()
        {
            Console.WriteLine("Enter a file name to open");
            string path = Console.ReadLine();

            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("\n");
                Console.WriteLine(content);
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Error: " + exeption.Message);
            }

        }
        
    }
}
