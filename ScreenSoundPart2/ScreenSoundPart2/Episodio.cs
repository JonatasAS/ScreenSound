class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Duracao { get;}
    public int Ordem { get;}
    public string Resumo => $"{Ordem}° {Titulo} ({Duracao} min) - convidados {string.Join(", ", convidados)}";
    public string Titulo { get;}

    public void AdionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}