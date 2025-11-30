using Cosmos.System.FileSystem.VFS;
using System;
using Sys = Cosmos.System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;
using SierraOS;

namespace SierraOS.Commands
{
    public class SetupVFS : Command
    {
       static Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

        public static long collectingDriveSpace;
        public static string collectingSystemFile;

        public static string collectingSystemLabel;
        public SetupVFS(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Question();
            return "";

        }

        public static void Question() //i dont know why its in a seperate void i thought it would fix something which wasnt even an issue 
        {
            Console.WriteLine("If no FAT formatted drive is present then SierraOS will\nbecome unresponsive. Continue? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                UAccount.LogIn.canStartVFS();
            }
            else
            {
                Console.WriteLine("Aborted");
            }
        }

        public static void VFS()
        {
            Console.WriteLine("Setting up VFS");
            try
            {

                /*var vfs = new Cosmos.System.FileSystem.CosmosVFS();
                VFSManager.RegisterVFS(vfs);
                Console.WriteLine("VFS setup");
                var free = vfs.GetAvailableFreeSpace(@"0:\");
                var total = vfs.GetTotalSize(@"0:\");
                Console.WriteLine($"Disk Size: {total / 1024 / 1024} MB");
                Console.WriteLine($"Free Space: {free / 1024 / 1024} MB");*/
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                Console.WriteLine("File System Successfully Enabled", Kernel.Status.OK);
                fs.Initialize(true);
                long collecting_drive_space1 = fs.GetAvailableFreeSpace("0:\\");
                string collecting_system_file1 = fs.GetFileSystemType("0:\\");

                var collecting_system_label1 = fs.GetFileSystemLabel("0:\\");

                collectingDriveSpace = collecting_drive_space1;
                collectingSystemFile = collecting_system_file1;
                collectingSystemLabel = collecting_system_label1;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Enable File System Fail Successfully", Kernel.Status.ERROR);
                Console.WriteLine($"Error : {ex}");
            }

        }
    }
}

