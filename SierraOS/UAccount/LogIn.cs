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
    public class LogIn
    {
        public static bool isLoggedIn = false;
        public static void login()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("VFS will be mounted");
            Console.ForegroundColor= ConsoleColor.White;
            var vfs = new Cosmos.System.FileSystem.CosmosVFS();
            VFSManager.RegisterVFS(vfs);
            Console.WriteLine("VFS was successfully mounted");
            Console.WriteLine("Username: ");
            string usernameInput = Console.ReadLine();
            string contentUser = File.ReadAllText("0:\\username.txt");
            if (usernameInput == contentUser)
            {
                Console.WriteLine("Password: ");
                string passwordInput = Console.ReadLine();
                string contentPass = File.ReadAllText("0:\\password.txt");
                if (passwordInput == contentPass)
                {
                    Console.WriteLine("Press any key");
                    isLoggedIn = true;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Boot.BootChime.chime();
                    Thread.Sleep(400);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Password incorrect");
                    login();
                }
            }

            else
            {
                Console.WriteLine("Username incorrect");
                login();
            }
        }


        public static void canStartVFS()
        {
            if (isLoggedIn ==  true)
            {
                Commands.SetupVFS.VFS();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are not logged in, please log in to start VFS.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        
    }
}
