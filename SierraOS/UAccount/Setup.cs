using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SierraOS.UAccount
{
    public class Setup
    {

        public static void disclaimer()
        {
            Console.Write("Creating a SierraOS user account requires mounting VFS.");
            Console.Write("\nSierraOS user accounts are insecure with their usernames and passwords\nbeing stored in plain text");
            Console.Write("\n\nContinue? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                setupAccount();
            }
            else
            {

            }
        }

        public static void setupAccount()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to user account setup");
            Console.WriteLine("\nEnter a username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();
            Console.WriteLine("VFS will now be mounted, if the system hangs or crashes VFS may\nnot be available");
            var vfs = new Cosmos.System.FileSystem.CosmosVFS();
            VFSManager.RegisterVFS(vfs);
            Console.WriteLine("VFS was successfully mounted");
            Console.WriteLine("Writing to username file");
            string fileName = "0:\\username.txt";
            string content = username;
            File.WriteAllText(fileName, content);
            Console.WriteLine("Username file written to");
            Console.WriteLine("Writing to password file");
            string fileName2 = "0:\\password.txt";
            string content2 = password;
            File.WriteAllText(fileName2, content2);
            Console.WriteLine("Password file was written to");
            Console.WriteLine("The system will reboot in 5 seconds");
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(500);
            Cosmos.System.Power.Reboot();




           
        }
    }
}
