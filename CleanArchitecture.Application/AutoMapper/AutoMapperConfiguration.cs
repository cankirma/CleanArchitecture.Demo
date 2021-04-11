using AutoMapper;

namespace CleanArchitecture.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config => { config.AddProfile(new AutoMapperProfile()); });

        }
    }
}