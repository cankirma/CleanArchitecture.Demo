using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Comtext
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
    }
}