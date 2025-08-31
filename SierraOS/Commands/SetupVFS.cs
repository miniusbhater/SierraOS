using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;

namespace SierraOS.Commands
{
    public class SetupVFS : Command
    {
        public SetupVFS(string name) : base(name) { }

        public override string execute(string[] args)
        {
            Question();
            return "";

        }

        public void Question() //i dont know why its in a seperate void i thought it would fix something which wasnt even an issue 
        {
            Console.WriteLine("If no FAT formatted drive is present then SierraOS will\nbecome unresponsive. Continue? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                VFS();
            }
            else
            {
                Console.WriteLine("Aborted");
            }
        }

        public void VFS()
        {

            Console.WriteLine("Setting up VFS");
            try
            {

                var vfs = new Cosmos.System.FileSystem.CosmosVFS();
                VFSManager.RegisterVFS(vfs);
                Console.WriteLine("VFS setup");
                var free = vfs.GetAvailableFreeSpace(@"0:\");
                var total = vfs.GetTotalSize(@"0:\");
                Console.WriteLine($"Disk Size: {total / 1024 / 1024} MB");
                Console.WriteLine($"Free Space: {free / 1024 / 1024} MB");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex}");
            }

        }
    }
}

