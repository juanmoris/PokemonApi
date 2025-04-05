using PokemonApi.Api;
using PokemonApi.Application.UseCases;
using PokemonApi.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfraestructureServices(builder.Configuration)
    .AddApiServices();

//builder.Services.AddSwaggerGen();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.MapGet("/pokemon/{name}", async (string name, GetPokemonUseCase useCase) =>
{
    var pokemon = await useCase.ExecuteAsync(name);
    return Results.Ok(pokemon);
});


app.Run();
