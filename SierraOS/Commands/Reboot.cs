using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Reboot : Command
    {
        public Reboot(string name) : base(name) { }

        public override string execute(string[] args)
        {
            doReboot();
            return "";

        }

        public void doReboot()
        {
            Cosmos.System.Power.Reboot();
        }
    }
}
