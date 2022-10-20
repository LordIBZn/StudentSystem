using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext (DbContextOptions<StudentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentSystem.Models.Student> Student { get; set; } = default!;
        public DbSet<StudentSystem.Models.Courses> Courses { get; set; }
        public DbSet<StudentSystem.Models.Resources> Resources { get; set; }
        public DbSet<StudentSystem.Models.Homework> Homeworks { get; set; }
        public DbSet<StudentSystem.Models.StudentCourse> StudentCourses { get; set; }

        //llave Compuesta Primaria
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new{c.StudentId, c.CourseId});
                
        }

    }
}
