namespace MovieManager
{
    public class Film
    {
        public int Id;
        public string Titlu;
        public string Gen;
        public int AnLansare;
        public int Durata;
        public string Regizor;
        public string Descriere;

        public Film(int id, string titlu, string gen, int anLansare, int durata, string regizor, string descriere)
        {
            Id = id;
            Titlu = titlu;
            Gen = gen;
            AnLansare = anLansare;
            Durata = durata;
            Regizor = regizor;
            Descriere = descriere;
        }

        public void AfiseazaFilm()
        {
            System.Console.WriteLine("Titlu: " + Titlu);
            System.Console.WriteLine("Gen: " + Gen);
            System.Console.WriteLine("An lansare: " + AnLansare);
            System.Console.WriteLine("Durata: " + Durata);
            System.Console.WriteLine("Regizor: " + Regizor);
            System.Console.WriteLine("Descriere: " + Descriere);
        }
    }
}