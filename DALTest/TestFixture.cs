using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL.util;
using Entry.model;

namespace DALTest
{
    public class TestFixture
    {
        private SchemaExportFixture fixture;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            fixture = new SchemaExportFixture();
        }

        [Test]
        public void TestCreate()
        {
           fixture.CreateTest();
        }
    }
}
