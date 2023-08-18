class Musica
{
    public Musica(Banda artista, string nome) 
    { 
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista}"; //Lambda

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição {DescricaoResumida}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
/*
Exemplo de editar um get
{
    get {
            return "Olá mundo!"
        }
}
*/