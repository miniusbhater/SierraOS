using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class Account : Command
    {
        public Account(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                return "Error: account requires an argument.\nUse 'account help' for a list of arguments.";
            }

            if (args[0] == "help")
            {
                UAccount.help.helphelp();
                return "";
            }

            if (args[0] == "new")
            {
                UAccount.Setup.disclaimer();
                return "";
            }


            return $"Error: Unknown argument.\nUse 'account help' for a list of arguments.";

        }

        public void theRest()
        {

        }
    }
}
