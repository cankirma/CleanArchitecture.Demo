using CleanArch.Domain.Interfaces;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class Bootstrapper
    {
        //other names for bootstrapper dependencycontainer/dependencyloader etc

        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer Services
            services.AddScoped<ICourseService, CourseService>();
            
            //infrastructure data layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
} 