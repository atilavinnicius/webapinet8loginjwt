using loginwebapijwt.Data.Seeds;
using loginwebapijwt.Enums;
using loginwebapijwt.Models;
using Microsoft.EntityFrameworkCore;

namespace loginwebapijwt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedUsers.Seed(modelBuilder);
        }
    }
}