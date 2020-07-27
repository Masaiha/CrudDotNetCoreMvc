using MASAIO.Business.Interfaces;
using MASAIO.Business.Interfaces.Services;
using MASAIO.Business.Notifications;
using MASAIO.Business.Services;
using MASAIO.Data.Context;
using MASAIO.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MASAIO.App.Configurations
{
    public static class DependencyInjectionsConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
