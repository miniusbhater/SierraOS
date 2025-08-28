using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Boot
{
   public class CpuUptime
    {
        public static void SysUptime()
        {
            string uptime;
            try
            {
                uptime = CPU.GetCPUUptime().ToString();
                Console.WriteLine($"CPU Uptime: {uptime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
