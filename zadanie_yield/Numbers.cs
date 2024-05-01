using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zadanie_yield
{
    internal class Numbers
    {
        private double[] array;

        private IEnumerable<double> iterator;


        public Numbers()
        {
            Console.Write("Podaj liczbę elementów w tablicy: ");
            int size = int.Parse(Console.ReadLine());
            array = new double[size];
            Console.WriteLine("Wprowadź elementy do tablicy, proszę używać przecinka jako separatora dziesiętnego: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Wygenerowana tablica:");
            foreach (double num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            iterator = RemoveDuplicates(array);
        }

        private IEnumerable<double> RemoveDuplicates(double[] array)
        {
            HashSet<double> seen = new HashSet<double>();
            foreach (double value in array)
            {
                if (seen.Add(value))  // Add zwraca true, jeśli element został dodany (nie był wcześniej w zbiorze)
                {
                    yield return value;
                }
            }
        }

        public void Without_duplicates()
        {
            Console.WriteLine("Tablica bez duplikatów:");
            foreach (double num in iterator)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


    }

}
