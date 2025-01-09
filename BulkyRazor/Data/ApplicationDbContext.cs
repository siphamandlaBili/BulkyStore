using Microsoft.EntityFrameworkCore;

namespace BulkyRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> category { get; set; }

    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    Id = 1,
                    Name = "Sample Task 2",
                    DisplayOrder = 2
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "Sample Task 2",
                    DisplayOrder = 1
                }
            );
        }
    }
}