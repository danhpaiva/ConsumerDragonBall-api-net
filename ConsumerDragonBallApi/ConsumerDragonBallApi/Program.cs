using ConsumerDragonBallApi.Models;
using System.Text.Json;
using static System.Console;

WriteLine("\nDigite o id para o personagem do anime: ");
var id = ReadLine();

string url = $"https://dragonball-api.com/api/characters/{id}";

using HttpClient client = new();

try
{
    var response = await client.GetStringAsync(url);

    var character = JsonSerializer.Deserialize<Character>(response, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

    WriteLine($"\nNome: {character.Name}");
    WriteLine($"Planeta de Origem: {character.OriginPlanet.Name}");

    WriteLine("Transformações:");
    foreach (var transformation in character.Transformations)
    {
        WriteLine($"- {transformation.Name}");
    }
}
catch (HttpRequestException e)
{
    WriteLine("Erro ao acessar a API: " + e.Message);
}
catch (JsonException e)
{
    WriteLine("Erro ao deserializar o JSON: " + e.Message);
}