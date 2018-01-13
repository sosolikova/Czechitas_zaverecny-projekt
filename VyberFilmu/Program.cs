using System;
using System.Collections.Generic;


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
            if (filmNahodneZvolenyDleUzivatelskychParametru == null)
            {
                Console.WriteLine("Film splňující vaše požadavky bohužel v databázi nemáte");
            }
            else
            {
                Console.WriteLine("{0} {1} žánry: {2}", filmNahodneZvolenyDleUzivatelskychParametru.Name, filmNahodneZvolenyDleUzivatelskychParametru.Country, String.Join(", ", filmNahodneZvolenyDleUzivatelskychParametru.Genre));
            }

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
