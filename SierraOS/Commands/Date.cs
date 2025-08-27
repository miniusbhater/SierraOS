using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace SierraOS.Commands
{
    public class Date : Command
    {
        public Date(string name) : base(name) { }

        public override string execute(string[] args)
        {
            DatePrint();
            return "";

        }

        public void DatePrint()
        {
            byte day = RTC.DayOfTheMonth;      
            byte month = RTC.Month;          
            ushort year = RTC.Year;
            Console.WriteLine($"{day:D2}/{month:D2}/{year}");
        }
    }
}
