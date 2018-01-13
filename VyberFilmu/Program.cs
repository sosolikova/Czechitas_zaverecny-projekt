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
           
            
            

            var vylosovaneZeme = movies.NahodnyVyberZemi();
            var vylosovanyZanr = movies.NahodnyVyberZanru();
            string vybranaZemeUzivatelem = VolbaUzivateleZeSeznamu(vylosovaneZeme,"zemi");
            string vybranyZanrUzivatelem = VolbaUzivateleZeSeznamu(vylosovanyZanr,"žánr");

            Movie filmNahodneZvolenyDleUzivatelskychParametru = movies.NahodnyVyberFilmuDleUzivatelskychParametru(vybranyZanrUzivatelem, vybranaZemeUzivatelem);
            Console.WriteLine("{0} {1} žánry: {2}", filmNahodneZvolenyDleUzivatelskychParametru.Name, filmNahodneZvolenyDleUzivatelskychParametru.Country,String.Join(", ", filmNahodneZvolenyDleUzivatelskychParametru.Genre));

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
            Console.ReadKey();
        }
        

        private static string VolbaUzivateleZeSeznamu(List<string> uzivatelskeVolby,string typVolby)
        {
            int vstupOdUzivatele = 0;
            string vyber = "";
            
            do
            {
                Console.WriteLine("Vyberte si {0}: \n\t 1. {1} \n\t 2. {2} \n\t 3. Opakování volby", typVolby, uzivatelskeVolby[0], uzivatelskeVolby[1]);
                vstupOdUzivatele = Int32.Parse(Console.ReadLine());

                switch (vstupOdUzivatele)
                {
                    case 1:
                        vyber = uzivatelskeVolby[0];
                        break;
                    case 2:
                        vyber = uzivatelskeVolby[1];
                        break;
                }

            } while (vyber == "");
            return vyber;
        }
    }
}
