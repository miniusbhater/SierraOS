using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Ver : Command
    {
        public Ver(string name) : base(name) { }

        public override string execute(string[] args)
        {
            VersionPrint();
            return "";

        }

        public void VersionPrint()
        {
            Console.WriteLine("SierraOS 0.04");
        }
    }
}
