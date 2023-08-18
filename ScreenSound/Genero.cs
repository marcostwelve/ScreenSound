class Genero
{
    public string NomeGenero { get; set; }

    public void ExibirGenero()
    {
        Console.WriteLine($"A música é do genero {NomeGenero}");
    }
}