using System.Collections.Generic;
using System.Linq;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArchitecture.Infra.Data.Comtext;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
          return  _context.Courses.ToList();
        }
    }
}