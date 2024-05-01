using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_delegaty
{
    internal class Program
    {

        static void Main()
        {
            Delegata del = new Delegata();

            del.Wyswietl();

            Console.WriteLine("Kryterium - liczby większe od liczb w tablicy, spełnające to kryterium.");
            Console.WriteLine($"Jest {del.CountMatches(del.numbers, del.Wieksze())} liczb spełniających kryterium.");

            Console.WriteLine("Kryterium - liczby mniejsze od liczb w tablicy, spełnające to kryterium.");
            Console.WriteLine($"Jest {del.CountMatches(del.numbers, del.Mniejsze())} liczb spełniających kryterium.");

            Console.WriteLine("Kryterium - liczby równe liczbom w tablicy, spełnające to kryterium.");
            Console.WriteLine($"Jest {del.CountMatches(del.numbers, del.Rowne())} liczb spełniających kryterium.");

        }
    }
}
