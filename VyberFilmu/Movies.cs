using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;





namespace VyberFilmu
{
    class Movies
    {
        private List<Movie> movies;

        public Movies()
        {
            movies = new List<Movie>();
        }
        public void PridatFilm()
        {
            Console.WriteLine("ZADÁNÍ NOVÉHO FILMU");
            Console.Write("Nazev: ");
            string name = Console.ReadLine();
            Console.Write("Country: ");
            string country = Console.ReadLine();
            Console.Write("Genre 1: ");
            string genre1 = Console.ReadLine();
            Console.Write("Genre 2: ");
            string genre2 = Console.ReadLine();
            Console.Write("Genre 3: ");
            string genre3 = Console.ReadLine();
            List<string> listGenre = new List<string>
            {
                genre1,
                genre2,
                genre3
            };
            Movie movie = new Movie(name, country, listGenre);
            movies.Add(movie);
        }
        public void VypisFilm()
        {
            Console.WriteLine("VYPIS FILMU");
            foreach (Movie movie in movies)
            {
                movie.VypisPopis();
            }
        }
        public void NactiFilmyZeSouboru()
        {
            using (StreamReader r = new StreamReader("Movies.json"))
            {
                string json = r.ReadToEnd();
                RootObject film = JsonConvert.DeserializeObject<RootObject>(json);
                Console.WriteLine($"Bylo nacteno {film.Movies.Count} filmu");

                foreach (Movie item in film.Movies)
                {

                    Console.WriteLine("{0} {1} žánry: {2}", item.Name, item.Country,String.Join(", ", item.Genre));
                }
            }
           
        }

        public class RootObject
        {
            public List<Movie> Movies { get; set; }
        }

    }
}
