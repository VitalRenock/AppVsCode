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
    }
}