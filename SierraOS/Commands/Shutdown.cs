using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Shutdown : Command
    {
        public Shutdown(string name) : base(name) { }

        public override string execute(string[] args)
        {
            doShutdown();
            return "";
          
        }

        public void doShutdown()
        {
            Cosmos.System.Power.Shutdown();
        }
    }
}
