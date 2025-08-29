using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Applications
{
    public interface IApplication
    {
        string Name { get; set; }

        string Description { get; set; }

        //int Version { get; set; }
    }
}
