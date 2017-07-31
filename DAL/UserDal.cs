using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entry.model;
using NHibernate;
using DAL.util;

namespace DAL
{
    public class UserDal
    {
        public static void InSertUser(User user)
        {
            if (user != null)
            {
                ISession session = NHibernateHelper.GetSession();
                ITransaction transaction = session.BeginTransaction();
                session.BeginTransaction();
                session.Save(user);
                session.Flush();
                transaction.Commit();
            }
           
        }
    }
}
