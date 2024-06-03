using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_plikowe
{
    internal static class KolekcjaManager
    {

        public static List<Osoba> WyszukajOsobyPoPesel(string pesel)
        {
            return Osoba.osoby.Where(o => o.NrPesel == pesel).ToList();
        }

        public static List<Osoba> WyszukajOsobyPoNazwisku(string nazwisko)
        {
            return Osoba.osoby.Where(o => o.Nazwisko == nazwisko).ToList();
        }

        public static List<Osoba> WyszukajOsobyPoMiescie(string miasto)
        {
            return Osoba.osoby.Where(o => o.Adres.Miasto == miasto).ToList();
        }

        public static void ZmienDaneOsoby(string noweImie, string noweNazwisko, int nowyWiek, int nowyWzrost, string nowyPesel, Adres nowyAdres)
        {
            Console.WriteLine("Czy chcesz zmienić dane osoby? Wpisz TAK jesli tak, a cokolwiek innego w przeciwnym wypadku");
            string odp = Console.ReadLine();

            if (odp == "TAK")
            {
                Console.WriteLine("Wprowadz id osoby, ktorej chcesz zmienic dane:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Osoby po zmianie:");
                var osoba = Osoba.osoby.FirstOrDefault(o => o.Id == id);
                if (osoba != null)
                {
                    osoba.Imie = noweImie;
                    osoba.Nazwisko = noweNazwisko;
                    osoba.Wiek = nowyWiek;
                    osoba.Wzrost = nowyWzrost;
                    osoba.NrPesel = nowyPesel;
                    osoba.Adres = nowyAdres;
                    PlikManager.ZapiszListeDoPliku(Osoba.osoby);
                }
                else
                {
                    Console.WriteLine("Osoba o podanym ID nie istnieje.");
                }
            }
        }
    }
}
