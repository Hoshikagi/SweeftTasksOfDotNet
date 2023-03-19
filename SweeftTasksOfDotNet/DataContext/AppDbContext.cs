using Microsoft.EntityFrameworkCore;
using SweeftTasksOfDotNet.Entities;

namespace SweeftTasksOfDotNet.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithMany(s => s.Teachers);
        }
    }
}