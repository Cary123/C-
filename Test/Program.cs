using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.util;
using Entry.model;
using DAL;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SchemaExportFixture().CreateTest();
            //Console.ReadLine();
            Fun1();
        }

        public static void Fun1()
        {
            User user = new User();
            user.Username = "Joseph";
            user.Age = 22;
            user.Gender = 'M';
            user.Password = "123456";
            user.LastLoginTime = DateTime.Now;
            UserDal.InSertUser(user);
        }
    }
}
