using DiscGolfWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscGolfWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Putting", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Driving", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Full Round", DisplayOrder = 3 }
                ); ;
        }
    }
}
