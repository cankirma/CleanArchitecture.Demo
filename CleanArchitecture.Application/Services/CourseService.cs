using System.Collections.Generic;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Core.Bus;
using MediatR;

namespace CleanArchitecture.Application.Services
{
    public class CourseService:ICourseService
    {
        private ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediatorHandler;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler)
        {
            _courseRepository = courseRepository;
            _mediatorHandler = mediatorHandler;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description,
                courseViewModel.ImageUrl);
            _mediatorHandler.SendCommand(createCourseCommand);
        }
    }
}