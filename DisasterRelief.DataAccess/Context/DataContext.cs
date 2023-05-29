using DataAccess.Entities.Concrete;
using DisasterRelief.DataAccess.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = BlogApp; Trusted_Connection = true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Demand> Demands { get; set; }
    }
}
