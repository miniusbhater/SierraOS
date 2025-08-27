using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Echo : Command
    {
        public Echo(string name) : base(name) { }

        public override string execute(string[] args)
        {
            echo();
            return "";

        }

        public void echo()
        {
            Console.WriteLine("Input something to echo");
            var input = Console.ReadLine();            
            Console.WriteLine(input);
        }
    }
}
