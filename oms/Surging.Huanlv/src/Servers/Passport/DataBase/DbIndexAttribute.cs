using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataBase
{

    public class DbIndexAttribute : Attribute
    {
        public string[] indexItem = null;

        public DbIndexAttribute()
        {

        }
        public DbIndexAttribute(string[] indexs)
        {
            indexItem = indexs;
        }
    }

    public static class EfCoreExtends
    {

        public static void AutoSetDbIndex(this ModelBuilder modelBuilder, Type type)
        {
            var prs = type.GetProperties();
            foreach (var item in prs)
            {
                var info = item.ToString();
                if (info.Contains("DbSet`1"))
                {
                    info = info.Replace("Microsoft.EntityFrameworkCore.DbSet`1[", "").Split(']')[0];
                    var modelType = Type.GetType(info);
                    if (modelType != null)
                    {
                        SetIndex(modelBuilder, modelType);
                    }
                }
            }
        }

        static void SetIndex(ModelBuilder modelBuilder, Type type)
        {
            var prs = type.GetProperties();
            foreach (var item in prs)
            {
                var at = (DbIndexAttribute)item.GetCustomAttribute(typeof(DbIndexAttribute));
                if (at != null)
                {
                    if (at.indexItem == null || at.indexItem.Length < 1)
                    {
                        at.indexItem = new string[] { item.Name };
                    }
                    modelBuilder.Entity(type).HasIndex(at.indexItem);
                }
            }
        }
    }
}
