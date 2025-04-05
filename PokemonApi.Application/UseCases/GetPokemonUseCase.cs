using PokemonApi.Application.Interfaces;
using PokemonApi.Domain.Entities;
using PokemonApi.Domain.Interfaces;

namespace PokemonApi.Application.UseCases;

public class GetPokemonUseCase
{
    private readonly IPokemonRepository _repository;
    private readonly IPokeApiService _pokeApiService;

    public GetPokemonUseCase(IPokemonRepository repository, IPokeApiService pokeApiService)
    {
        _repository = repository;
        _pokeApiService = pokeApiService;
    }

    public async Task<Pokemon> ExecuteAsync(string name)
    {
        var existing = await _repository.GetByNameAsync(name);
        if (existing is not null) return existing;

        var fromApi = await _pokeApiService.GetPokemonByNameAsync(name);
        await _repository.AddAsync(fromApi!);
        return fromApi!;
    }
}