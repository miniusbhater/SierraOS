using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cosmos.HAL;

namespace SierraOS.Boot
{
    public class BootChime
    {
        public static void chime()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.M)
            {
                Console.WriteLine("Startup sound skipped");
            }           
            else
            {
                PCSpeaker.Beep(523, 200);
                Thread.Sleep(50);
                PCSpeaker.Beep(587, 200);
                Thread.Sleep(50);
                PCSpeaker.Beep(659, 200);
                Thread.Sleep(50);
                PCSpeaker.Beep(783, 300);
                Thread.Sleep(50);
                PCSpeaker.Beep(1046, 400);
            }          
        }
    }
}
