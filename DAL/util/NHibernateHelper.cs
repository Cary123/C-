using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace DAL.util
{
    public class NHibernateHelper
    {
        private static readonly ISessionFactory SessionFactory;

        private static readonly ThreadLocal<ISession> localSession = new ThreadLocal<ISession>();

        //private static ISession session

        static NHibernateHelper()
        {
            SessionFactory = new Configuration().Configure().BuildSessionFactory();
        }

        public static ISessionFactory GetSessionFactory()
        {
            return SessionFactory;
        }

        public static ISession GetSession()
        {
            if (localSession.Value == null)
            {
                ISession session = SessionFactory.OpenSession();
                localSession.Value = session;
            }
            return localSession.Value;
        }

        public static void CloseSessionFactory()
        {
            if (localSession.Value != null)
            {
                localSession.Value = null;
            }
        }
    }
}
