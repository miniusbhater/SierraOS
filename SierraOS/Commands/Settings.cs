using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Settings : Command
    {
        public Settings(string name) : base(name) { }

        public override string execute(string[] args)
        {
            aSettings();
            return "";

        }

        public void aSettings()
        {
            Console.Clear();
            Thread.Sleep(368);
            Console.WriteLine("This menu is currently non-functional press any key to return");
            Thread.Sleep(200);            
        }
    }
}
