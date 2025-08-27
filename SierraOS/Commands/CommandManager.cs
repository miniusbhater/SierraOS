using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    internal class CommandManager
    {
        private List<Command> commands;

        public CommandManager()
        {
            this.commands = new List<Command>(1);
            this.commands.Add(new Commands.Help("help"));
            this.commands.Add(new Commands.Return(""));
            this.commands.Add(new Commands.Shutdown("shutdown"));
            this.commands.Add(new Commands.Reboot("reboot"));
            this.commands.Add(new Commands.Ver("ver"));
            this.commands.Add(new Commands.Clear("clear"));
        }

        public string processInput(string input)
        {
            string[] split = input.Split(' ');

            string label = split[0];

            List<string> args = new List<string>();

            int ctr = 0;
            foreach (string s in split)
            {
                if (ctr != 0)
                {
                    args.Add(s);
                }
                ctr++;
            }

            foreach (Command cmd in this.commands)
            {
                if (cmd.name == label)
                {
                    return cmd.execute(args.ToArray());
                }
            }

            return "Command \"" + label + "\" does not exist!";
        }
    }
}
