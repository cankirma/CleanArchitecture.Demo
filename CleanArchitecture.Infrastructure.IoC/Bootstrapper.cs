using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Infra.Data.Comtext;
using CleanArchitecture.Infra.Data.Repository;
using CleanArchitecture.Infrastructure.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class Bootstrapper
    {
        //other names for bootstrapper dependencycontainer/dependencyloader etc

        public static void RegisterServices(IServiceCollection services)
        {
            //domain inmemorybus mediatr

            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            //Application Layer Services
            services.AddScoped<ICourseService, CourseService>();
            
            //infrastructure data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>(); 

        }
    }
} 