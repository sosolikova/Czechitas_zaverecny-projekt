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
    class Program
    {
        static void Main(string[] args)
        {
            Movies movies = new Movies();
            movies.NactiFilmyZeSouboru();
            movies.NahodnyVyberZanru();


            var vylosovaneZeme = movies.NahodnyVyberZemi();
            string vybranaZemeUzivatelem = VyberUzivateleZeme(vylosovaneZeme);

            int volbaMenu = 0;
            do
            {
                Console.WriteLine("HLAVNI MENU");
                Console.WriteLine("\t 1. Pridat film");
                Console.WriteLine("\t 2. Vypsat filmy");
                Console.WriteLine("\t 3. Nacti filmy ze souboru");
                Console.WriteLine("\t 4. Ukoncit program");

                volbaMenu = Int32.Parse(Console.ReadLine());
                switch (volbaMenu)
                {
                    case 1:
                        movies.PridatFilm();
                        break;
                    case 2:
                        movies.VypisFilm();
                        break;
                    case 3:
                        movies.NactiFilmyZeSouboru();
                        break;
                }

            } while (volbaMenu != 4);
        }

        private static string VyberUzivateleZeme(List<string> vylosovaneZeme)
        {
            int vybranaVolba = 0;
            string vybranyZanr = "";
            do
            {
                Console.WriteLine("Vyberte si žánr: \n\t 1. {0} \n\t 2. {1} \n\t 3. Opakování volby", vylosovaneZeme[0], vylosovaneZeme[1]);
                vybranaVolba = Int32.Parse(Console.ReadLine());

                switch (vybranaVolba)
                {
                    case 1:
                        vybranyZanr = vylosovaneZeme[0];
                        break;
                    case 2:
                        vybranyZanr = vylosovaneZeme[1];
                        break;
                }

            } while (vybranyZanr == "");
            return vybranyZanr;
        }
    }
}
