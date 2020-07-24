using MASAIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MASAIO.App.Configurations
{
    public static class DbConfig
    {
        public static IServiceCollection AddDbConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
