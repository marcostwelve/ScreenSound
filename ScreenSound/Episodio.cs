class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(string titulo, int duracao) 
    {
        Titulo = titulo;
        Duracao = duracao;
    }
    public int Duracao { get; }
    public List<string> Ordem = new List<string>();
    public string Resumo => $"{Titulo}. ({Duracao} min) - Convidado: {string.Join(", ", convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
        Ordem.Add(Titulo);
        Console.WriteLine($"Convidado {convidado} adicionado com sucesso");
        List<string> ordem = Ordem.OrderBy(t => t).ToList();
        foreach (string ordemItem in ordem)
        {
            Console.WriteLine($"Episódio: {ordemItem}");
        }
        
    }
}