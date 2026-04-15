using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;


namespace StudentManagementSystem.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>()
                .HasIndex(s => s.Email)
                .IsUnique();

            builder.Entity<Student>()
                .Property(s => s.Name)
                .HasMaxLength(100);

            builder.Entity<Student>()
                .Property(s => s.Email)
                .HasMaxLength(150);

            builder.Entity<Student>()
                .Property(s => s.Course)
                .HasMaxLength(100);
        }
    }
}