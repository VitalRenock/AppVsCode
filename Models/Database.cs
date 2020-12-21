using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppVsCode.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) 
        {
            
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=MyDatabase.db");
        
        public DbSet<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
    }
}


//   "ConnectionStrings": {
//     "SqliteConnectionString": "Data Source=MyDatabase.db"
//   }