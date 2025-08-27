using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class Clear : Command
    {
        public Clear(string name) : base(name) { }

        public override string execute(string[] args)
        {
            ClearScreen();
            return "";

        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
