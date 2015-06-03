using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Jobers.Domain.Model;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace Infrastructure.Repository
{
    public static class GerenciadorConexaoNHibernate
    {
        private static ISessionFactory _sessionFactory { get; set; }
        private static object _locker = new object();

        public static ISessionFactory Obter()
        {
            if (_sessionFactory != null)
            {
                return _sessionFactory;
            }

            lock (_locker)
            {
                if (_sessionFactory != null)
                    return _sessionFactory;

                Configuration cfg = new Configuration();

                cfg = cfg.Configure("hibernate.xml.cfg");
                cfg.AddAssembly(Assembly.GetAssembly(typeof(GerenciadorConexaoNHibernate)));

                _sessionFactory = cfg.BuildSessionFactory();

                return _sessionFactory;
            }
        }



        public static ISession ObterSession()
        {
            return Obter().GetCurrentSession();
        }

        public static IQueryable<T> ObterQuery<T>() where T : IEntidade
        {
            return ObterSession().Query<T>();
        }

    }
}
