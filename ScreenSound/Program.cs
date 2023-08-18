Banda queen = new Banda("Queen");


Album albumDoQueen = new Album("A Night At The Opera");


Musica musica1 = new Musica(queen, "Love Of My Life")
{
    // Inicializando propriedades opcionais
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

Genero genero1 = new Genero();
genero1.NomeGenero = "Rock";

Genero genero2 = new Genero();
genero2.NomeGenero = "Indie";

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicaDoAlbum();



queen.AdicioonarAlbum(albumDoQueen);
queen.ExibirDiscografia();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

genero1.ExibirGenero();
genero2.ExibirGenero();

Episodio episodio1 = new Episodio("Hello Word", 120);
episodio1.AdicionarConvidados("Bill Gates");
Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio("C#", 300);
episodio2.AdicionarConvidados("João");
Console.WriteLine(episodio2.Resumo);

PodCast pod1 = new PodCast("C#", "Marcos");

pod1.AdicionarEpisodio(episodio1);
pod1.AdicionarEpisodio(episodio2);
pod1.ExibirDetalhes();