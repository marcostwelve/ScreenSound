class Banda
{
    public Banda(string nome) 
    {
        Nome = nome;
    }
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public void AdicioonarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Álbuns: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}