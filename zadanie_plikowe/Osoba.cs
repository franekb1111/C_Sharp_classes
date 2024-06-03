using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_plikowe
{
    internal class Osoba
    {
        public static List<Osoba> osoby = new List<Osoba>();

        private static int currentId = 0;

        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public int Wzrost { get; set; }
        public string NrPesel { get; set; }
        public Adres Adres { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}, Wzrost: {Wzrost} cm, PESEL: {NrPesel}, Adres: {Adres}";
        }

        public Osoba(int id, string imie, string nazwisko, int wiek, int wzrost, string nrPesel, Adres adres)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Wzrost = wzrost;
            NrPesel = nrPesel;
            Adres = adres;
        }

        public static void DodajOsobe(string imie, string nazwisko, int wiek, int wzrost, string nrPesel, Adres adres)
        {
            Osoba nowaOsoba = new Osoba(currentId++, imie, nazwisko, wiek, wzrost, nrPesel, adres);
            osoby.Add(nowaOsoba);
        }

        public static void UsunOsobe(int id)
        {
            Osoba osobaDoUsuniecia = osoby.Find(o => o.Id == id);
            if (osobaDoUsuniecia != null)
            {
                osoby.Remove(osobaDoUsuniecia);
            }
            else
            {
                Console.WriteLine("Osoba o podanym ID nie istnieje.");
            }
        }

        public static void WyswietlOsoby()
        {
            if (osoby.Count == 0)
            {
                Console.WriteLine("Brak osób w kolekcji.");
                return;
            }

            foreach (var osoba in osoby)
            {
                Console.WriteLine(osoba);
            }
        }

    }
}
