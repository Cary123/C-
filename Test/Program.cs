using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.util;
using Entry.model;
using DAL;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SchemaExportFixture().DropTest();

            //new SchemaExportFixture().CreateTest();

            //new SchemaExportFixture().ExecuteTest();

            //TestGenerationStrategy();

            //TestCascade();

            TestStoreProcedure();

            //Console.ReadLine();
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
            user.Email = "123@qq.com";
            user.Phone = "13958574758";
            user.LastUpdateTime = DateTime.Now;
            UserDal.InsertUser(user);
        }

        public static void InsertProduct()
        {
            Product product = new Product();
        }

        public static void TestCascade()
        {
            User user = new User();
            user.UserId = new Guid("0D9CE6F3-B3D8-4553-8B8C-AE040C8B695E");
            user.Username = "Cary";
            user.Password = "123456";
            user.Age = 12;
            user.Email = "123@qq.com";
            user.Phone = "1241414425";
            user.Orders = new HashSet<Order>();
            Order order = new Order();          
            order.OrderId = new Guid("9ECE8114-E4FA-4E17-B841-1D78B1415876");
            order = new OrderDal().GetOrder(order.OrderId);
            user.Orders.Add(order);
            UserDal.DeleteUser(user);
        }

        public static void TestStoreProcedure()
        {
            Thread thread1 = new Thread(new ThreadStart(UseStoreProcedure));
            Thread thread2 = new Thread(new ThreadStart(UseNHibernate));
            thread1.Start();
            thread2.Start();                    
        }

        public static void UseStoreProcedure()
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;
            order.OrderId = new Guid("088FB71D-34A3-47D4-BC1F-3B61FEBCEDD1");
            EnterpriseDal.DeleteOrder(order.OrderId);
        }

        public static void UseNHibernate()
        {
            Order order = new Order();
            order.OrderId = new Guid("088FB71D-34A3-47D4-BC1F-3B61FEBCEDD1");
            order.OrderDate = DateTime.Now;
            OrderDal.DeleteOrder(order);
        }
    }
}
