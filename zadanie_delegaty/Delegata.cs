using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_delegaty
{
    internal class Delegata
    {
        // Definicja delegata
        public delegate bool Delegat(int number);

        public int[] numbers;

        public Delegata()
        {
            // Stworzenie tablicy liczb całkowitych z losowymi wartościami
            Random random = new Random();
            numbers = new int[10];
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); // Liczby od 1 do 100
            }
        }

        public void Wyswietl()
        {
            Console.WriteLine("Tablica:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public Delegat Wieksze()
        {
            Console.Write("Podaj kryterium, które określa, ile liczb tablicy ma być większe od tej liczby: ");
            int threshold = int.Parse(Console.ReadLine());
            Delegat wieksze = (int x) => { return x > threshold; };
            return wieksze;
        }

        public Delegat Mniejsze()
        {
            Console.Write("Podaj kryterium, które określa, ile liczb tablicy ma być mniejsze od tej liczby: ");
            int threshold = int.Parse(Console.ReadLine());
            Delegat mniejsze = (int x) => { return x < threshold; };
            return mniejsze;
        }

        public Delegat Rowne()
        {
            Console.Write("Podaj kryterium, które określa, ile liczb tablicy ma być równe tej liczbie: ");
            int threshold = int.Parse(Console.ReadLine());
            Delegat rowne = (int x) => { return x == threshold; };
            return rowne;
        }


        public int CountMatches(int[] array, Delegat crit)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (crit(number))
                {
                    count++;
                }
            }
            return count;
        }

    }
}



