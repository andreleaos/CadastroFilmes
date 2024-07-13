using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Infrastructure.Repositories;
using CadastroFilmes.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroFilmes.IoC;
public class Startup
{
    public static void Configure(IConfiguration configuration, IServiceCollection services)
    {
        services.AddScoped<FilmeRepository, FilmeRepositoryImpl>();
        services.AddScoped<FilmeService, FilmeServiceImpl>();
    }
}
