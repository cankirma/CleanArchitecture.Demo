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

    
        IQueryable<Course> ICourseRepository.GetCourses()
        {
          return  _context.Courses;
          
        }
        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

       
    }
}