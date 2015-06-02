using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Infrastructure.IOC
{
    public static class IOC
    {
        [ThreadStatic]
        private static IWindsorContainer _container;

        [ThreadStatic]
        private static object _locker = new object();


        public static void Configure()
        {
            
            _container = new WindsorContainer();
            _container.Install(new AssemblyInstaller(Assembly.GetAssembly(typeof (IOC)), new InstallerFactory()));

        }

        public static T Get<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
