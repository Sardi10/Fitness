using FitnessWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessWebsite.Data
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
                new Category { Id = 1, Name = "Protein", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Service", DisplayOrder = 2 }
                );
        }
    }
}
