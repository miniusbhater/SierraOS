using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class Beep : Command
    {
        public Beep(string name) : base(name) { }

        public override string execute(string[] args)
        {
            BeepBeep();
            return "Beep!";

        }

        public void BeepBeep()
        {
            Console.Beep();
        }
    }
}
