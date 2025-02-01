using Microsoft.EntityFrameworkCore;

namespace SampleApi.Models
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
        }


        public DbSet<Course> Courses { get; set; }
    }
}