using Dapper;
using PokemonApi.Domain.Entities;
using PokemonApi.Domain.Interfaces;
using System.Data;

namespace PokemonApi.Infraestructure.Data;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonDbContext _context;
    private readonly IDbConnection _connection;

    public PokemonRepository(PokemonDbContext context, IDbConnection connection)
    {
        _context = context;
        _connection = connection;
    }

    public async Task<Pokemon?> GetByNameAsync(string name)
    {
        var sql = "SELECT * FROM Pokemons WHERE Name = @Name";
        return await _connection.QueryFirstOrDefaultAsync<Pokemon>(sql, new { Name = name });
    }

    public async Task AddAsync(Pokemon pokemon)
    {
        _context.Pokemons.Add(pokemon);
        await _context.SaveChangesAsync();
    }
}
