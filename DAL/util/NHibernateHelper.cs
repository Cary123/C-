using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System.Data.SqlClient;

namespace DAL.util
{
    public class NHibernateHelper
    {
        private static readonly ISessionFactory SessionFactory;

        private static readonly ThreadLocal<ISession> localSession = new ThreadLocal<ISession>();

        private static SqlConnection conn = null;

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

        public static void CloseSession()
        {
            if (localSession.Value != null)
            {
                ISession session = localSession.Value;
                session.Close();
                localSession.Value = null;
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            ISession session = null;
            SqlConnection conn = null;
            if (localSession.Value != null)
            {
                session = localSession.Value;
                conn = new SqlConnection(session.Connection.ConnectionString);
            }
            else
            {
                session = GetSession();
                conn = new SqlConnection(session.Connection.ConnectionString);
            }
            return conn;
        }
    }
}
