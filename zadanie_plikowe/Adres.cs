using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_plikowe
{
    internal class Adres
    {

        public static List<Adres> adresy = new List<Adres>();

        private static int currentId = 0;

        public int Id { get; private set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public int NrDomu { get; set; }
        public int? NrMieszkania { get; set; }

        public Adres(int id, string miasto, string kodPocztowy, string ulica, int nrDomu, int? nrMieszkania)
        {
            Id = currentId++;
            Miasto = miasto;
            KodPocztowy = kodPocztowy;
            Ulica = ulica;
            NrDomu = nrDomu;
            NrMieszkania = nrMieszkania;
        }

        public static void DodajAdres(string miasto, string kodPocztowy, string ulica, int nrDomu, int? nrMieszkania)
        {
            Adres nowyAdres = new Adres(currentId++, miasto, kodPocztowy, ulica, nrDomu, nrMieszkania);
            adresy.Add(nowyAdres);
        }

        public override string ToString()
        {   if (NrMieszkania != null)
                return $"{Ulica} {NrDomu}/{NrMieszkania}, {KodPocztowy} {Miasto}";
            else
                return $"{Ulica} {NrDomu}, {KodPocztowy} {Miasto}";
        }

        public static void UsunAdres(int id)
        {
            Adres adresDoUsuniecia = adresy.Find(a => a.Id == id);
            if (adresDoUsuniecia != null)
            {
                adresy.Remove(adresDoUsuniecia);
            }
            else
            {
                Console.WriteLine("Adres o podanym ID nie istnieje.");
            }
        }

        public static void WyswietlAdresy()
        {
            if (adresy.Count == 0)
            {
                Console.WriteLine("Brak adresów w kolekcji.");
                return;
            }

            foreach (var adres in adresy)
            {
                Console.WriteLine(adres);
            }
        }
    }
}
