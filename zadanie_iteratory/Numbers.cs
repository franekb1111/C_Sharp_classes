using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_iteratory
{
    internal abstract class Numbers
    {
        private int[] array;

        private List<int> oddNumbers;


        public Numbers()
        {
            Console.Write("Podaj liczbę elementów w tablicy: ");
            int size = int.Parse(Console.ReadLine());
            array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 101);  // Liczby od 1 do 100
            }

            oddNumbers = Filter_odd(array);

            Console.WriteLine("Wygenerowana tablica:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private List<int> Filter_odd(int[] array)
        {
            List<int> oddNumbers = new List<int>();
            foreach (int number in array)
            {
                if (number % 2 != 0)  // Sprawdzanie, czy liczba jest nieparzysta
                {
                    oddNumbers.Add(number);
                }
            }
            return oddNumbers;
        }

        protected uint Count()
        {
            IEnumerator<int> iterator = oddNumbers.GetEnumerator();
            uint number = 0;
            while (iterator.MoveNext())
            {
                number++;
            }
            return number;
        }
        protected void Show()
        {
            IEnumerator<int> iterator = oddNumbers.GetEnumerator();
            while (iterator.MoveNext())
            {
                int element = iterator.Current;
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
