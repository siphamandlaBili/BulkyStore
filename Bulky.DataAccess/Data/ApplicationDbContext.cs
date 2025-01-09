using Bulky.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {    
        }

        public DbSet<CategoryModel> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "Sci-FI",
                    DisplayOrder = 2
                }, new CategoryModel
                {
                    Id = 3,
                    Name = "Anime",
                    DisplayOrder = 3
                }
            );
        }
    }
}
