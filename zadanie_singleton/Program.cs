using System;
using System.Collections.Generic;
using System.Linq;

namespace zadanie_singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            Console.Write("Enter the range (0 to N): ");
            int range = int.Parse(Console.ReadLine());

            // Generate random numbers
            Random random = new Random();
            int[] randomNumbers = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                randomNumbers[i] = random.Next(range + 1);
            }

            // Display generated numbers
            Console.WriteLine("Generated numbers: " + string.Join(", ", randomNumbers));

            // Get the Singleton instance and filter odd numbers
            OddNumberFilter oddNumberFilter = OddNumberFilter.GetInstance();
            List<int> oddNumbers = oddNumberFilter.FilterOddNumbers(randomNumbers);

            // Display filtered odd numbers
            Console.WriteLine("Odd numbers: ");
            oddNumberFilter.DisplayList();

            // Remove numbers less than the user-defined value
            Console.Write("Enter the minimum value to keep in the list: ");
            int minValue = int.Parse(Console.ReadLine());
            oddNumberFilter.RemoveNumbersLessThan(minValue);

            // Display the list after removing elements
            Console.WriteLine("List after removing elements less than " + minValue + ": ");
            oddNumberFilter.DisplayList();
        }
    }
}
