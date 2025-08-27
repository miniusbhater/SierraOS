using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class list : Command
    {
        public list(string name) : base(name) { }

        public override string execute(string[] args)
        {
            ls();
            return "";

        }

        public void ls()
        {
            try
            {
                string[] files = Directory.GetFiles(@"0:\");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                string[] dirs = Directory.GetDirectories(@"0:\");
                foreach (var dir in dirs)
                {
                    Console.WriteLine("(DIRECTORY) " + dir);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            }
            
    }
}
