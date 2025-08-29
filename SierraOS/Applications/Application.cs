using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Applications
{
    public abstract class Application : IApplication
    {
        string IApplication.Name { get; set; }

        string IApplication.Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void Initialize();

        public abstract void Run();
    }
}
