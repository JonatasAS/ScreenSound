class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}

    public int Duracao => musicas.Sum(m => m.Duracao);

    public Genero Genero { get; set; }

    public void AdicionarMusica(Musica musica) {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}");
        Console.WriteLine($"Estilo musical do album: {Genero.Nome}\n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nTempo de duração total desse álbum: {Duracao} segundos");
    }
}
