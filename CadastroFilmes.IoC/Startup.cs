using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.Infrastructure.Contexts;
using CadastroFilmes.Infrastructure.Repositories;
using CadastroFilmes.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroFilmes.IoC;
public class Startup
{
    public static void Configure(IConfiguration configuration, IServiceCollection services)
    {
        ConfigureDatabase(configuration, services);

        services.AddScoped<FilmeRepository, FilmeRepositoryImpl>();
        services.AddScoped<FilmeService, FilmeServiceImpl>();
    }

    private static void ConfigureDatabase(IConfiguration configuration, IServiceCollection services)
    {
        string connStr = configuration.GetConnectionString("FilmeDB");

        services.AddDbContext<FilmeDbContext>(opt =>
        opt.UseSqlServer(connStr));
    }
}
