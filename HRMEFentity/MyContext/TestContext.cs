﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using HRMEFentity.Entity;
namespace HRMEFentity.MyContext
{
    public class TestContext : DbContext
    {
        public TestContext()
            : base("name=sql")
        {
            //Database.SetInitializer<TestContext>(null);禁止建库操作
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Car> Cares { set; get; }
    }
}
