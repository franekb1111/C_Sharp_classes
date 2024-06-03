using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace zadanie_plikowe
{
    internal class PlikManager
    {
        private const string sciezkaPliku = "osoby.json";

        public static void ZapiszListeDoPliku(List<Osoba> listaOsob)
        {
            var opcje = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(listaOsob, opcje);

            using (var fs = new FileStream(sciezkaPliku, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.Write(jsonString);
            }
        }

        public static List<Osoba> OdczytajListeZPliku()
        {
            if (!File.Exists(sciezkaPliku))
            {
                Console.WriteLine("Plik nie istnieje.");
                return new List<Osoba>();
            }

            using (var fs = new FileStream(sciezkaPliku, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                var jsonString = sr.ReadToEnd();
                return JsonSerializer.Deserialize<List<Osoba>>(jsonString);
            }
        }
    }
}
