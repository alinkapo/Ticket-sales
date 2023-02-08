using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_sales.Models
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
        public DbSet<Ticket > Tickets { get; set; }
        public DbSet<Passanger> Passangers{ get; set; }

        public ApplicationContext() 
        { 
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tickets.db");
        }
    }
}
