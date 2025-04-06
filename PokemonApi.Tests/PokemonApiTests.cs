using Microsoft.Playwright;

namespace PokemonApi.Tests;

public class PokemonApiTests
{
    [Fact]
    public async Task Buscar_Pikachu_DeberiaMostrarResultado()
    {
        using var playwright = await Playwright.CreateAsync();
        var request = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions
        {
            BaseURL = "http://localhost:5000"
        });

        var response = await request.GetAsync("/pokemon/pikachu");

        Assert.True(response.Ok);
        var json = await response.JsonAsync();
        Assert.Equal("pikachu", json?.GetProperty("name").GetString());
    }
}