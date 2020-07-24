using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MASAIO.App.Configurations
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services) 
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }
    }
}
