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
            movies.NahodnyVyberZemi();
            movies.NahodnyVyberZanru();
            
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

            } while (volbaMenu !=4);


        }
    }
}
