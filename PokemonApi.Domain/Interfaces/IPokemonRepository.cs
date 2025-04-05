using PokemonApi.Domain.Entities;

namespace PokemonApi.Domain.Interfaces;

public interface IPokemonRepository
{
    Task<Pokemon?> GetByNameAsync(string name);
    Task AddAsync(Pokemon pokemon);
}