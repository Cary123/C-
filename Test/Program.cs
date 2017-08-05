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
            //new SchemaExportFixture().DropTest();

            //new SchemaExportFixture().CreateTest();

            new SchemaExportFixture().ExecuteTest();

            //TestGenerationStrategy();

            //Console.ReadLine();
        }

        /// <summary>
        /// Test SchemaExport.
        /// </summary>
        public static void TestSchemaExport()
        {
            User user = new User();
            user.UserId = Guid.NewGuid();
            user.Username = "Joseph" + DateTime.Now;
            user.Age = 22;
            user.Gender = 'M';
            user.Password = "123456";
            user.LastLoginTime = DateTime.Now;
            UserDal.InSertUser(user);
        }

        /// <summary>
        /// Primary key generation strategy
        /// </summary>
        public static void TestGenerationStrategy()
        {
            User user = new User();
            user.UserId = Guid.NewGuid();
            user.Username = "Joseph"+DateTime.Now;
            user.Age = 22;
            user.Gender = 'M';
            user.Password = "123456";
            user.LastLoginTime = DateTime.Now;
            UserDal.InSertUser(user);
        }
    }
}
