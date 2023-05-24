using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MM.Classes
{
    internal class MMContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Importance> Importances { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Spendings> Spendings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source = {"MMDb.db"}");
        
    }
}
