﻿class Banda
{
    List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Àlbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}