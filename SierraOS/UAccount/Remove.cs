using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SierraOS.UAccount
{
    public class Remove
    {
        public static void removeAccount()
        {
            Console.WriteLine("If you are logged in the system will crash.");
            Thread.Sleep(1500);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("VFS will be mounted");
            Thread.Sleep(1000);
            var vfs = new Cosmos.System.FileSystem.CosmosVFS();
            VFSManager.RegisterVFS(vfs);
            Console.WriteLine("Scanning for user account");
            string user = File.ReadAllText("0:\\username.txt");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"Are you sure you want to remove {user}\n(y/n)");
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y )
            {
                File.Delete("0:\\username.txt");
                File.Delete("0:\\password.txt");
                Console.WriteLine("Account removed.");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exiting...");
                Thread.Sleep(200);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exiting...");
                Console.BackgroundColor= ConsoleColor.Black;
                Console.Clear();
            }
        }
    }
}
