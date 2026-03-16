using System;

namespace MovieManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] filme = new Film[10];
            int numarFilme = 0;
            int optiune;

            do
            {
                Console.WriteLine("1. Adauga film");
                Console.WriteLine("2. Afiseaza filme");
                Console.WriteLine("3. Cauta film dupa titlu");
                Console.WriteLine("0. Iesire");

                Console.Write("Alege optiunea: ");
                optiune = int.Parse(Console.ReadLine());

                if (optiune == 1)
                {
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Titlu: ");
                    string titlu = Console.ReadLine();

                    Console.Write("Gen: ");
                    string gen = Console.ReadLine();

                    Console.Write("An lansare: ");
                    int an = int.Parse(Console.ReadLine());

                    filme[numarFilme] = new Film(id, titlu, gen, an);
                    numarFilme++;
                }

                else if (optiune == 2)
                {
                    for (int i = 0; i < numarFilme; i++)
                    {
                        filme[i].Afisare();
                    }
                }

                else if (optiune == 3)
                {
                    Console.Write("Introdu titlul cautat: ");
                    string titluCautat = Console.ReadLine();

                    for (int i = 0; i < numarFilme; i++)
                    {
                        if (filme[i].Titlu == titluCautat)
                        {
                            filme[i].Afisare();
                        }
                    }
                }

            } while (optiune != 0);
        }
    }
}