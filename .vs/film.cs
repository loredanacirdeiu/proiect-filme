namespace MovieManager
{
    public class Film
    {
        public int Id;
        public string Titlu;
        public string Gen;
        public int AnLansare;

        public Film(int id, string titlu, string gen, int anLansare)
        {
            Id = id;
            Titlu = titlu;
            Gen = gen;
            AnLansare = anLansare;
        }

        public void Afisare()
        {
            System.Console.WriteLine("ID: " + Id);
            System.Console.WriteLine("Titlu: " + Titlu);
            System.Console.WriteLine("Gen: " + Gen);
            System.Console.WriteLine("An lansare: " + AnLansare);
            System.Console.WriteLine("---------------------");
        }
    }
}