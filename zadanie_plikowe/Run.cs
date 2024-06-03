using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_plikowe
{
    internal class Run
    {
        public Run()
        {
            Adres.DodajAdres("Warszawa", "00-001", "Marszałkowska", 1, 1);
            Adres.DodajAdres("Kraków", "30-001", "Floriańska", 15, null);

            Osoba.DodajOsobe("Jan", "Kowalski", 30, 180, "12345678901", Adres.adresy[0]);
            Osoba.DodajOsobe("Anna", "Nowak", 25, 165, "09876543210", Adres.adresy[1]);

            Console.WriteLine("Adresy  i osoby przed usunieciem:\n");
            Adres.WyswietlAdresy();
            Osoba.WyswietlOsoby();


            PlikManager.ZapiszListeDoPliku(Osoba.osoby);

            Adres.UsunAdres(1);
            Osoba.UsunOsobe(1);


            Console.WriteLine("\nAdresy  i osoby po usunieciu:\n");
            Adres.WyswietlAdresy();
            Osoba.WyswietlOsoby();


            Console.Write("\nWyszukaj osoby po peselu: ");
            var osobyPoPesel = KolekcjaManager.WyszukajOsobyPoPesel(Console.ReadLine());
            Console.WriteLine("Osoby po PESELu:\n");
            foreach (var osoba in osobyPoPesel)
            {
                Console.WriteLine(osoba);
            }

            Console.Write("\nWyszukaj osoby po nazwisku: ");
            var osobyPoNazwisku = KolekcjaManager.WyszukajOsobyPoNazwisku(Console.ReadLine());
            Console.WriteLine("Osoby po nazwisku:\n");
            foreach (var osoba in osobyPoNazwisku)
            {
                Console.WriteLine(osoba);
            }

            Console.Write("\nWyszukaj osoby po miescie: ");
            var osobyPoMiescie = KolekcjaManager.WyszukajOsobyPoMiescie(Console.ReadLine());
            Console.WriteLine("Osoby po mieście:\n");
            foreach (var osoba in osobyPoMiescie)
            {
                Console.WriteLine(osoba);
            }


            Adres.DodajAdres("Kraków", "30-001", "Floriańska", 18, null);

            // Zmien dane osoby
            KolekcjaManager.ZmienDaneOsoby("Anna", "Nowak", 26, 166, "09876543211", Adres.adresy[1]);


            Console.WriteLine("Osoby:");
            Osoba.WyswietlOsoby();

            var odczytaneOsoby = PlikManager.OdczytajListeZPliku();
            Console.WriteLine("\nOsoby odczytane z pliku:\n");
            foreach (var osoba in odczytaneOsoby)
            {
                Console.WriteLine(osoba);
            }
        }
    }
}
