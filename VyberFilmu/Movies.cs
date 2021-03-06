﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;


namespace VyberFilmu
{
    class Movies
    {

        private Dictionary<string, string> unikatniSeznamZanru = new Dictionary<string, string>();
        private Dictionary<string, string> unikatniSeznamZemi = new Dictionary<string, string>();
        private Random losovani = new Random();
        private DatabazeFilmu databaze;


        public void NactiFilmyZeSouboru()
        {
            using (StreamReader r = new StreamReader("Movies.json"))
            {
                string json = r.ReadToEnd();
                databaze = JsonConvert.DeserializeObject<DatabazeFilmu>(json);
                Console.WriteLine($"Vaše databáze obsahuje {databaze.Movies.Count} filmů.\n");

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

        private List<string> NahodnyVyber(Dictionary<string,string> unikatniSeznam)
        {
            List<string> listNahodnych = new List<string>();

            int nahodneCislo1;
            int nahodneCislo2;
            do
            {
                nahodneCislo1 = losovani.Next(unikatniSeznam.Count);
                nahodneCislo2 = losovani.Next(unikatniSeznam.Count);
  
            } while (nahodneCislo1 == nahodneCislo2);

            listNahodnych.Add(unikatniSeznam.ToArray()[nahodneCislo1].Value);
            listNahodnych.Add(unikatniSeznam.ToArray()[nahodneCislo2].Value);

            return listNahodnych;
        }

        public List<string> NahodnyVyberZanru()
        {
            return NahodnyVyber(unikatniSeznamZanru);
        }

        public List<string> NahodnyVyberZemi()
        {
            return NahodnyVyber(unikatniSeznamZemi);
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
            if (listFilmuSplnujicichPodminky.Count < 1)
            {
                return null;
            }
            else
            {
                var nahodneCislo = losovani.Next(listFilmuSplnujicichPodminky.Count);
                return listFilmuSplnujicichPodminky[nahodneCislo];
            }
        }

        public class DatabazeFilmu
        {
            public List<Movie> Movies { get; set; }
        }

    }
}
