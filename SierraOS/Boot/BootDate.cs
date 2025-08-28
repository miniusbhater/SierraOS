using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using SierraOS.Commands;

namespace SierraOS.Boot
{
    public class BootDate 
    {
        public static void Date()
        {
            byte day = RTC.DayOfTheMonth;
            byte month = RTC.Month;
            ushort year = RTC.Year;

            Console.WriteLine($"Boot Date: {day:D2}/{month:D2}/{year}");
        }
    }
}
