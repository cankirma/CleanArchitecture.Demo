using CleanArchitecture.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}