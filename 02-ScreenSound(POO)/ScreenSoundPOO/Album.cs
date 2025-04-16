﻿class Album 
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void ExibirListaDeMusicas()
    {
        Console.WriteLine($"Lista de músicas do àlbum {Nome}:\n");
        foreach (var musica in  musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este àlbum inteiro você precisa de {DuracaoTotal}");
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
}