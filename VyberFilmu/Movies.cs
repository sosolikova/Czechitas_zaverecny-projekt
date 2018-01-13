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
