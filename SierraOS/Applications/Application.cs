using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SierraOS.Applications
{
    public abstract class Application : IApplication
    {
        public abstract string appName();
        public abstract string appCommand();

        string IApplication.Name
        {
            get => appName();
            set => throw new NotImplementedException();
        }

        string IApplication.Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IApplication.Command
        {
            get => appCommand();
            set => throw new NotImplementedException();
        }

        public abstract void Initialize();

        public abstract void Run();
    }
}
