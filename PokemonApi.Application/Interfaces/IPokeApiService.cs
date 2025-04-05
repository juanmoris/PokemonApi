using PokemonApi.Domain.Entities;

namespace PokemonApi.Application.Interfaces;

public interface IPokeApiService
{
    Task<Pokemon?> GetPokemonByNameAsync(string name);
}