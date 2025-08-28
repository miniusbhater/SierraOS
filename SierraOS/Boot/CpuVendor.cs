using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Boot
{
    public class CpuVendor
    {
        public static void cpu()
        {
            string cpuvendor;
            cpuvendor = CPU.GetCPUVendorName();
            Console.WriteLine(cpuvendor);
        }
    }
}
