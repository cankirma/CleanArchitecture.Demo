using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }
    }
}