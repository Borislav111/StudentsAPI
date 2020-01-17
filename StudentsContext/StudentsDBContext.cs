using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.StudentsContext
{
    public class StudentsDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BORISLAV\SQLEXPRESS;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentGrades>().HasKey(sg => new { sg.StudentId, sg.GradesId });
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<StudentGrades> StudentGrades { get; set; }

    }
}
