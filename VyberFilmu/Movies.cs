﻿using System;
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
        private Dictionary<string,string> unikatniSeznamZanru = new Dictionary<string, string>();
        private Dictionary<string, string> unikatniSeznamZemi = new Dictionary<string, string>();
        private Random losovani = new Random();
        private DatabazeFilmu databaze;

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
                databaze = JsonConvert.DeserializeObject<DatabazeFilmu>(json);
                Console.WriteLine($"Bylo nacteno {databaze.Movies.Count} filmu");

                foreach (Movie item in databaze.Movies)
                {

                    
                    foreach (string genre in item.Genre)
                    {
                        if (!unikatniSeznamZanru.ContainsKey(genre))
                        {
                            unikatniSeznamZanru.Add(genre, genre);
                        }
                    }

                    if (!unikatniSeznamZemi.ContainsKey(item.Country))
                    {
                        unikatniSeznamZemi.Add(item.Country, item.Country);
                    }
                }
            }          
        }

        public List<string> NahodnyVyberZemi()
        {
            List<string> listNahodnychZemi = new List<string>();
            var nahodneCislo = losovani.Next(unikatniSeznamZemi.Count);
            listNahodnychZemi.Add(unikatniSeznamZemi.ToArray()[nahodneCislo].Value);
            nahodneCislo = losovani.Next(unikatniSeznamZemi.Count);
            listNahodnychZemi.Add(unikatniSeznamZemi.ToArray()[nahodneCislo].Value);
            return listNahodnychZemi;
        }

        public List<string> NahodnyVyberZanru()
        {
            List<string> listNahodnych = new List<string>();
            
            var nahodneCislo = losovani.Next(unikatniSeznamZanru.Count);
            listNahodnych.Add(unikatniSeznamZanru.ToArray()[nahodneCislo].Value);
            nahodneCislo = losovani.Next(unikatniSeznamZanru.Count);
            listNahodnych.Add(unikatniSeznamZanru.ToArray()[nahodneCislo].Value);
            return listNahodnych;
        }
        public Movie NahodnyVyberFilmuDleUzivatelskychParametru(string genre, string country)
        {
            List<Movie> listFilmuSplnujicichPodminky = new List<Movie>();
            foreach (Movie film in databaze.Movies)
            {
                if (country == film.Country && film.Genre.Contains(genre))
                {
                    listFilmuSplnujicichPodminky.Add(film);
                }
            }
            var nahodneCislo = losovani.Next(listFilmuSplnujicichPodminky.Count);
            
            return listFilmuSplnujicichPodminky[nahodneCislo];
        }

        public class DatabazeFilmu
        {
            public List<Movie> Movies { get; set; }
        }

    }
}
