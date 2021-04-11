using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);

        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description,
            //    courseViewModel.ImageUrl);
            _mediatorHandler.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));

        }
    }
}