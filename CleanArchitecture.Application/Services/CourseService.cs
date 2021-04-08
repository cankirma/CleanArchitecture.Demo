using System.Collections.Generic;
using CleanArch.Domain.Interfaces;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Services
{
    public class CourseService:ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}