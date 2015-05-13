using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace Infrastructure.Repository
{
    public static class GerenciadorConexaoNHibernate
    {
        private static ISessionFactory _sessionFactpry { get; set; }
        private static object _lovker = new object();

        public static ISessionFactory Obter()
        {
            if (_sessionFactpry != null)
            {
                return _sessionFactpry;
            }

            lock (_lovker)
            {
                if (_sessionFactpry != null)
                {
                    return _sessionFactpry;
                }
                Configuration cfg = new Configuration();
                cfg = cfg.Configure();
                cfg.AddAssembly(Assembly.GetAssembly(typeof(GerenciadorConexaoNHibernate)));

                _sessionFactpry = cfg.BuildSessionFactory();

                return _sessionFactpry;
            }
        }

    }
}
