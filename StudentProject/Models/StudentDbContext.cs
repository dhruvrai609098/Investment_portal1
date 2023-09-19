using Microsoft.EntityFrameworkCore;
using StudentProject.Models;

namespace StudentProject.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        //public DbSet<Student> Student { get; set; }
        public DbSet<UserModel> UserModel { get; set; }

    }
}