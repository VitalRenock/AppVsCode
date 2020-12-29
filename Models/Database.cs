using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppVsCode.Models;

namespace AppVsCode.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) { }
        public DbSet<Post> Posts { get; set; }

        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        //     var entityMethod = typeof(DbModelBuilder).GetMethod("Entity");

        //     foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        //     {
        //         var entityTypes = assembly
        //           .GetTypes()
        //           .Where(t =>
        //             t.GetCustomAttributes(typeof(PersistentAttribute), inherit: true)
        //             .Any());

        //         foreach (var type in entityTypes)
        //         {
        //             entityMethod.MakeGenericMethod(type)
        //               .Invoke(modelBuilder, new object[] { });
        //         }
        //     }
        // }

    }
}