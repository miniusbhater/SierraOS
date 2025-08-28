using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// do not document in help
namespace SierraOS.Commands
{
    public class Github : Command
    {
        public Github(string name) : base(name) { }

        public override string execute(string[] args)
        {
            GithubLink();
            return "";

        }

        public void GithubLink()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("https://github.com/miniusbhater/SierraOS/");
            Console.ResetColor();
        }
    }
}
