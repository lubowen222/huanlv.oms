using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class MysqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=;database=huanlv.passport;");
        }

        /// <summary>
        /// 重写OnModelCreating方法，添加自定义规则
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AutoSetDbIndex(this.GetType());///通过特性生成索引 [DbIndex]
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TestModel> TestModels { get; set; }
        public DbSet<User> UserModels { get; set; }
        public DbSet<UserWxInfo> UserWxInfoModels { get; set; }

    }
}
