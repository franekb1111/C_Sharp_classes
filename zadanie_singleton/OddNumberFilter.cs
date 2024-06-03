using System;
using System.Collections.Generic;
using System.Linq;

namespace zadanie_singleton
{
    public class OddNumberFilter
    {
        // Singleton instance
        private static OddNumberFilter instance;
        private List<int> numbers;

        private OddNumberFilter()
        {
            numbers = new List<int>();
        }

        // Singleton getInstance method
        public static OddNumberFilter GetInstance()
        {
            if (instance == null)
            {
                instance = new OddNumberFilter();
            }
            return instance;
        }

        public List<int> FilterOddNumbers(int[] array)
        {
            numbers = array.Where(num => num % 2 != 0).ToList();
            return numbers;
        }

        public void DisplayList()
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        public void RemoveNumbersLessThan(int value)
        {
            numbers = numbers.Where(num => num >= value).ToList();
        }
    }
}
