class PodCast
{ 
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }
    private List<Episodio> episodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        int num = 1;
        Console.WriteLine($"PodCast {Nome}. Apresentado por {Host}");
        foreach(Episodio episodio in episodios)
        {
            Console.WriteLine($"Episódio {num}: {episodio.Resumo}");
            num++;
        }
        Console.WriteLine($"Total de episódios: {episodios.Count()}");
    }
}