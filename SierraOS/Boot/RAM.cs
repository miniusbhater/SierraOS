using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Boot
{
    internal class RAM
    {
        public static void RAMStuff()
        {
            string availram;
            string usedram;
            availram = GCImplementation.GetAvailableRAM().ToString();
            usedram = GCImplementation.GetUsedRAM().ToString();
            Console.WriteLine($"{availram} system RAM free");
            Console.WriteLine($"{usedram} system ram used");
        }
    }
}
