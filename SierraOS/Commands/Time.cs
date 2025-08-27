using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace SierraOS.Commands
{
    public class Time : Command
    {
        public Time(string name) : base(name) { }

        public override string execute(string[] args)
        {
            TimePrint();
            return "";

        }

        public void TimePrint()
        {
            byte hours = RTC.Hour;
            byte minutes = RTC.Minute;
            byte seconds = RTC.Second;

            Console.WriteLine($"Current Time: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
