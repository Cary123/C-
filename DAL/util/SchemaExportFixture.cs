﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace DAL.util
{
    /// <summary>
    /// 描述：SchemaExport生成数据库架构操作类
    /// 创建人：wolfy
    /// 创建时间：2014-11-16
    /// </summary>
    public class SchemaExportFixture
    {
        private Configuration cfg;
        public SchemaExportFixture()
        {
            cfg = new Configuration();
            cfg.Configure();
        }
        public void DropTest()
        {
            var export = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            export.Drop(true, true);
        }
        public void CreateTest()
        {
            var export = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            export.Create(true, true);
            export.SetOutputFile("E:\\sql.sql"); //设置输出目录  
        }
        public void ExecuteTest()
        {
            var export = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            export.Execute(true, true, false);
        }
    }
}