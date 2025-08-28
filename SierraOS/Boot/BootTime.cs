using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace SierraOS.Boot
{
    public class BootTime
    {
        public static void Time()
        {
            byte hours = RTC.Hour;
            byte minutes = RTC.Minute;
            byte seconds = RTC.Second;

            Console.WriteLine($"Boot Time: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
