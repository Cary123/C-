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
        public User GetUser(Guid userId)
        {
            ISession session = null;
            try
            {
                User user = null;
                if (userId != Guid.Empty)
                {
                    session = NHibernateHelper.GetSession();
                    user = (User)session.Get(typeof(User), userId);
                }
                return user;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public static void InsertUser(User user)
        {
            ISession session = null;
            ITransaction transaction = null;
            try
            {
                if (user != null)
                {
                    session = NHibernateHelper.GetSession();
                    transaction = session.BeginTransaction();
                    session.BeginTransaction();
                    session.Save(user);
                    session.Flush();
                    transaction.Commit();
                }
            }
            catch (Exception)
            {

                transaction.Rollback();
                throw;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }          
        }

        public static void UpdateUser(User user)
        {
            ISession session = null;
            ITransaction transaction = null;
            try
            {
                if (user != null)
                {
                    session = NHibernateHelper.GetSession();
                    transaction = session.BeginTransaction();
                    session.BeginTransaction();
                    session.Update(user);
                    session.Flush();
                    transaction.Commit();
                }
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                NHibernateHelper.CloseSession();                
            }
        }

        public static void DeleteUser(User user)
        {
            ISession session = null;
            ITransaction transaction = null;
            try
            {
                if (user != null)
                {
                    session = NHibernateHelper.GetSession();
                    transaction = session.BeginTransaction();
                    session.BeginTransaction();
                    session.Delete(user);
                    session.Flush();
                    transaction.Commit();
                }
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }
    }
}
