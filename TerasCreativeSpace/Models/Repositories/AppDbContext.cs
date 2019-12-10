using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerasCreativeSpace.Models;
using Microsoft.EntityFrameworkCore;

namespace TerasCreativeSpace.Models.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
