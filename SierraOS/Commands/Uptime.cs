using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// do not document in help
namespace SierraOS.Commands
{
     public class Uptime : Command
    {
        public Uptime(string name) : base(name) { }

        public override string execute(string[] args)
        {
            CpuUptime();
            return "";

        }

        public void CpuUptime()
        {
            string uptime;
            try
            {
                uptime = CPU.GetCPUUptime().ToString();
                Console.WriteLine($"Current CPU uptime: {uptime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
