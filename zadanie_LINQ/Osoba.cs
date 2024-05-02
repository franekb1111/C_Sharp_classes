using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_LINQ
{
    internal class Osoba
    {
        public string Imie
        { get; set; }
        public string Nazwisko
        { get; set; }
        public int Wiek
        { get; set; }
        public int Id
        { get; set; }
        public string Wyksztalcenie
        { get; set; }

        public override string ToString()
        {
            return Id.ToString() + "; " + Imie + " " + Nazwisko + "; " + Wiek + "; " + Wyksztalcenie;
        }
    }
}
