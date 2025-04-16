using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musica => musica.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por genero musical >>> {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Exibindo músicas do artista >>> {artista}");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int key, string tonalidade)
        {
            var musicasDaTonalidade = musicas.Where(musica => musica.Key.Equals(1)).Select(musica => musica.Nome).Distinct().ToList();
            Console.WriteLine($"Exibindo todas as músicas da tonalidade {tonalidade}");
            foreach (var musica in musicasDaTonalidade)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
