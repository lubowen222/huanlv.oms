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
            optionsBuilder.UseMySql("server=101.132.155.202;user id=root;password=Lu@1989222;database=dev_passport;");
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
        public DbSet<AccountModel> AccountModels { get; set; }
        public DbSet<UserInfoModel> UserInfoModels { get; set; }

    }
}
