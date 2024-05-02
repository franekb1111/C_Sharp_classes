using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_LINQ
{
    internal class Osoba_kol
    {
        private List<Osoba> listaOsob;

        public Osoba_kol()
        {
            listaOsob = new List<Osoba>();
            dodajListeOsob();
        }

        private void dodajListeOsob()
        {
            listaOsob.AddRange(new List<Osoba>
            {
                new Osoba() { Id = 1, Imie = "Jan", Nazwisko = "Firlit", Wiek = 12, Wyksztalcenie = "Średnie" },
                new Osoba() { Id = 2, Imie = "Marcin", Nazwisko = "Malon", Wiek = 32, Wyksztalcenie = "Średnie" },
                new Osoba() { Id = 3, Imie = "Marina", Nazwisko = "Byk", Wiek = 22, Wyksztalcenie = "Średnie" },
                new Osoba() { Id = 4, Imie = "Iza", Nazwisko = "Malon", Wiek = 4, Wyksztalcenie = "Wyższe" },
                new Osoba() { Id = 5, Imie = "Bonifacy", Nazwisko = "Firlit", Wiek = 33, Wyksztalcenie = "Podstawowe" },
                new Osoba() { Id = 6, Imie = "Jan", Nazwisko = "Byk", Wiek = 19, Wyksztalcenie = "Wyższe" },
            });
        }

        public void DodajOsobe()
        {

            Console.Write("Ile nowych osób chcesz dodać? Wprowadź liczbę: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Podaj Imię:");
                string imie = Console.ReadLine();

                Console.WriteLine("Podaj Nazwisko:");
                string nazwisko = Console.ReadLine();

                Console.WriteLine("Podaj Wiek:");
                int wiek = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj Wykształcenie:");
                string wyksztalcenie = Console.ReadLine();

                int newId = listaOsob.Count > 0 ? listaOsob[^1].Id + 1 : 1;

                Osoba nowaOsoba = new Osoba() { Id = newId, Imie = imie, Nazwisko = nazwisko, Wiek = wiek, Wyksztalcenie = wyksztalcenie };

                listaOsob.Add(nowaOsoba);
                Console.WriteLine("Osoba dodana pomyślnie.");
            }
        }

        public void uruchom()
        {
            var ListaOsobDodanych = from osoba in listaOsob
                                    select osoba;
            Console.WriteLine("Zawartość kolekcji:");
            foreach (var element in ListaOsobDodanych)
                Console.WriteLine(element);
            Console.WriteLine();

            var ListaOsobTeSameImiona = from osoba in listaOsob
                                        group osoba by osoba.Imie into grupa
                                        select grupa;
            foreach (var grupa in ListaOsobTeSameImiona)
            {
                Console.WriteLine("Osoby o imieniu: " + grupa.Key);
                foreach (var osoba in grupa)
                {
                    Console.WriteLine(osoba.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Wprowadź wiek od którego wyświetlone osoby mają być starsze: ");
            int wiek = int.Parse(Console.ReadLine());

            Console.WriteLine($"Osoby starsze niż {wiek} lat");
            var ListaOsobWiek = from osoba in listaOsob
                                where osoba.Wiek > wiek
                                orderby osoba.Wiek
                                select osoba;

            foreach (var element in ListaOsobWiek)
                Console.WriteLine(element);
            Console.WriteLine();

            var ListaOsobId = from osoba in listaOsob
                              orderby osoba.Id
                              select osoba;
            Console.WriteLine("Zawartość kolekcji posortowana po ID: ");
            foreach (var element in ListaOsobId)
                Console.WriteLine(element);
            Console.WriteLine();

            var ListaOsobToSamoWyksztalcenie = from osoba in listaOsob
                                               group osoba by osoba.Wyksztalcenie into grupa
                                               select grupa;
            foreach (var grupa in ListaOsobToSamoWyksztalcenie)
            {
                Console.WriteLine("Osoby o wykształceniu: " + grupa.Key);
                foreach (var osoba in grupa)
                {
                    Console.WriteLine(osoba.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Najstarsza osoba:");
            var OsobaNajstarsza = (from osoba in listaOsob
                                   orderby osoba.Wiek descending
                                   select osoba).FirstOrDefault();
            Console.WriteLine(OsobaNajstarsza);
            Console.WriteLine();


            Console.WriteLine("Najnowsza najmłodsza osoba:");
            var OsobaNajnowszaNajmlodsza = (from osoba in listaOsob
                                            orderby osoba.Id descending, osoba.Wiek
                                            select osoba).FirstOrDefault();

            Console.WriteLine(OsobaNajnowszaNajmlodsza);
            Console.WriteLine();
        }
    }
}
