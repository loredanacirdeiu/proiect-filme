using System.Collections.Generic;

namespace MovieManager
{
    public class FilmService
    {
        public List<Film> filme = new List<Film>();

        public void AdaugaFilm(Film film)
        {
            filme.Add(film);
        }

        public void AfiseazaToateFilmele()
        {
            foreach (Film film in filme)
            {
                film.AfiseazaFilm();
                System.Console.WriteLine("-------------------");
            }
        }

        public void StergeFilm(int id)
        {
            for (int i = 0; i < filme.Count; i++)
            {
                if (filme[i].Id == id)
                {
                    filme.RemoveAt(i);
                    break;
                }
            }
        }

        public Film CautaFilmDupaTitlu(string titlu)
        {
            foreach (Film film in filme)
            {
                if (film.Titlu == titlu)
                {
                    return film;
                }
            }

            return null;
        }
    }
}