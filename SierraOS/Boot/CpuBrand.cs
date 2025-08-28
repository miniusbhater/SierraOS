using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Boot
{
    public class CpuBrand
    {
        public static void brand()
        {
            string brand;
            brand = CPU.GetCPUBrandString();
            Console.WriteLine(brand);
        }
    }
}
