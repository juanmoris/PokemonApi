using Microsoft.EntityFrameworkCore;
using PokemonApi.Domain.Entities;

namespace PokemonApi.Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Pokemon> Pokemons { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}