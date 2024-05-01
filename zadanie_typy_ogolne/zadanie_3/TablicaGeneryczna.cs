using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class TablicaGeneryczna<T>
    {
        private T[] tablica;

        public TablicaGeneryczna(int rozmiar)
        {
            tablica = new T[rozmiar];
        }

        public void Get_value(int indeks)
        {
            if (indeks >= 0 && indeks < tablica.Length)
            {
                Console.WriteLine(indeks + ". element tablicy wynosi: " + tablica[indeks]);
            }
            else
            {
                Console.WriteLine("Indeks poza zakresem tablicy");
                return;
            }
        }

        public void Set_value(int indeks, T wartosc)
        {
            if (indeks >= 0 && indeks < tablica.Length)
            {
                tablica[indeks] = wartosc;
            }
            else
            {
                Console.WriteLine("Indeks poza zakresem tablicy");
                return;
            }
        }
    }
}
