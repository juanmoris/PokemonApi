using PokemonApi.Application.Interfaces;
using PokemonApi.Infraestructure.Services;

namespace PokemonApi.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services.AddHttpClient<IPokeApiService, PokeApiService>();

        // Otros servicios (casos de uso, repositorios, etc.)
        return services;
    }
}