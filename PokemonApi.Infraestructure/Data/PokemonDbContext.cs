using Microsoft.EntityFrameworkCore;
using PokemonApi.Application.Interfaces;
using PokemonApi.Domain.Entities;

namespace PokemonApi.Infraestructure.Data;

public class PokemonDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Pokemon> Pokemons => Set<Pokemon>();
    public PokemonDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}