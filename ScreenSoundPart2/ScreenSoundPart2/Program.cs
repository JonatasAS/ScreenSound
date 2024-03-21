Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");
albumDoQueen.Genero = new Genero { Nome = "Rock" };

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponibilidade = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponibilidade = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();

Episodio ep1 = new(1, "Programando em C#", 40);
ep1.AdionarConvidados("Marcelo");
ep1.AdionarConvidados("João");

Episodio ep2 = new(2, "Sobre a Linguagem", 50);
ep2.AdionarConvidados("Marcelo");
ep2.AdionarConvidados("João");
ep2.AdionarConvidados("Juana");

Podcast podcast = new("Jonatas", "Apredendo a ser um Dev de respeito");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);

podcast.ExibirDetalhes();
