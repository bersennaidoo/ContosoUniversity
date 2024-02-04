using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
        public DbSet<ContosoUniversity.Models.Enrollment> Enrollments { get; set; } = default!;
        public DbSet<ContosoUniversity.Models.Course> Courses { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContosoUniversity.Models.Course>().ToTable("Course");
            modelBuilder.Entity<ContosoUniversity.Models.Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<ContosoUniversity.Models.Student>().ToTable("Student");
        }
    }
}
