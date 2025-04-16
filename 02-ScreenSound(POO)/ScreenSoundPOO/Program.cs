Banda queen = new Banda("Queen");

Album albumDoQueen =  new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life") { Duracao = 213, Disponivel = true };

Musica musica2 = new Musica(queen, "Bohemian Rhapsody") { Duracao = 345, Disponivel = false};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirListaDeMusicas();
//queen.ExibirDiscografia();

Episodio ep1 = new(2, "O Podpah é Israel dos Podcasts?", 112);
ep1.AdicionarConvidados("Arthur Petry");
ep1.AdicionarConvidados("Caio Del'Aqua");
ep1.AdicionarConvidados("Gianzão");

Episodio ep2 = new(1, "ChatGPT x Studio Ghibli", 91);
ep2.AdicionarConvidados("Alvaro");
ep2.AdicionarConvidados("Fernando");

Podcast podcast = new("Igor 3K", "Flow Podcast");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();
