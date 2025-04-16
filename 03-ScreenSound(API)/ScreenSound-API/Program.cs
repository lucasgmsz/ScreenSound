using System.Text.Json;
using ScreenSound_API.Modelos;
using ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Linkin Park");
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 1, "C#");

        //var musicasPreferidas= new MusicasPreferidas("Enzo");
        //musicasPreferidas.AdicionarMusicaFavorita(musicas[762]);
        //musicasPreferidas.AdicionarMusicaFavorita(musicas[97]);
        //musicasPreferidas.AdicionarMusicaFavorita(musicas[9]);
        //musicasPreferidas.AdicionarMusicaFavorita(musicas[1500]);
        //musicasPreferidas.AdicionarMusicaFavorita(musicas[951]);

        //musicasPreferidas.ExibirMusicasFavoritas();
        //musicasPreferidas.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}