using Microsoft.EntityFrameworkCore;
using StudentProject.Models;

namespace StudentProject.Models
{
    public class InvestorDbContext : DbContext
    {
        public InvestorDbContext(DbContextOptions<InvestorDbContext> options) : base(options)
        {
        }
        //public DbSet<Student> Student { get; set; }
        public DbSet<UserModel> UserModel { get; set; }

    }
}