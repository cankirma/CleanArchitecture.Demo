using AutoMapper;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Models;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>().ConstructUsing(c=> new CreateCourseCommand(c.Name,c.Description,c.ImageUrl)).ReverseMap();
            CreateMap<Course, CourseViewModel>().ReverseMap();
        }

       
    }
    
}