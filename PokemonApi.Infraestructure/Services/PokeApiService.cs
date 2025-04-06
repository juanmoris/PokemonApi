using PokemonApi.Application.Dtos;
using PokemonApi.Application.Interfaces;
using PokemonApi.Domain.Entities;
using System.Text.Json;

namespace PokemonApi.Infraestructure.Services;

public class PokeApiService : IPokeApiService
{
    private readonly HttpClient _httpClient;
    public PokeApiService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<Pokemon?> GetPokemonByNameAsync(string name)
    {
        var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name.ToLower()}");

        if (!response.IsSuccessStatusCode) return null;

        var json = await response.Content.ReadAsStringAsync();

        var data = JsonSerializer.Deserialize<PokeApiDto>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        if (data is null) return null;

        return new Pokemon
        {
            Name = data.Name,
            Height = data.Height,
            Weight = data.Weight
        };
    }
}