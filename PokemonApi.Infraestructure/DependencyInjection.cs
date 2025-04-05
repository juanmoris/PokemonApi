using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokemonApi.Application.Interfaces;
using PokemonApi.Application.UseCases;
using PokemonApi.Domain.Interfaces;
using PokemonApi.Infraestructure.Data;
using System.Data;

namespace PokemonApi.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");

        services.AddDbContext<PokemonDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        services.AddScoped<IDbConnection>(_ => new SqlConnection(connectionString));
        services.AddScoped<IApplicationDbContext, PokemonDbContext>();

        services.AddScoped<IPokemonRepository, PokemonRepository>();
        services.AddScoped<GetPokemonUseCase>();

        return services;
    }
}