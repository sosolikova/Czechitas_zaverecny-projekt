using System;
using System.Collections.Generic;


namespace VyberFilmu
{
    class Program
    {
        static void Main(string[] args)
        {
            string provestOpakovani;

            do
            {
                Movies movies = new Movies();
                movies.NactiFilmyZeSouboru();


                string vybranaZemeUzivatelem = VolbaUzivateleZeSeznamu("zemi", movies);
                string vybranyZanrUzivatelem = VolbaUzivateleZeSeznamu("žánr", movies);

                Movie filmNahodneZvolenyDleUzivatelskychParametru = movies.NahodnyVyberFilmuDleUzivatelskychParametru(vybranyZanrUzivatelem, vybranaZemeUzivatelem);
                if (filmNahodneZvolenyDleUzivatelskychParametru == null)
                {
                    Console.WriteLine("Film splňující vaše požadavky bohužel v databázi nemáte\n");
                }
                else
                {
                    Console.WriteLine("Vybraný film:");
                    Console.WriteLine("\tNázev:\t{0} \n\tZemě:\t{1} \n\tŽánry:\t{2}", filmNahodneZvolenyDleUzivatelskychParametru.Name, filmNahodneZvolenyDleUzivatelskychParametru.Country, String.Join(", ", filmNahodneZvolenyDleUzivatelskychParametru.Genre));
                }
                Console.WriteLine("\nPřejete si opakovat volbu filmu? \nPokud ano, stiskněte A, pokud ne stiskněte jakoukoliv klávesu.");
                provestOpakovani = Console.ReadLine().ToLower();

            } while (provestOpakovani == "a");
        }

        private static string VolbaUzivateleZeSeznamu(string typVolby,Movies movies)
        {
            int vstupOdUzivatele = 0;
            string vyber = "";
            List<string> uzivatelskeVolby;
            do
            {
                if (typVolby == "žánr")
                {
                    var vylosovanyZanr = movies.NahodnyVyberZanru();
                    uzivatelskeVolby = vylosovanyZanr;
                }
                else
                {
                    var vylosovaneZeme = movies.NahodnyVyberZemi();
                    uzivatelskeVolby = vylosovaneZeme;
                }

                Console.WriteLine("Vyberte si {0}: \n\t 1. {1} \n\t 2. {2} \n\t 3. Opakování volby", typVolby, uzivatelskeVolby[0], uzivatelskeVolby[1]);
                var nactena = Console.ReadLine();
                if (Int32.TryParse(nactena,out vstupOdUzivatele))
                {
                    vyber = "";
                }       

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
