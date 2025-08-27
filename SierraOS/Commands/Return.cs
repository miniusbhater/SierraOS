using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Commands
{
    public class Return : Command
    {

        public Return(string name) : base(name) { }

        public override string execute(string[] args)
        {           
            return "";
        }

    }
}
