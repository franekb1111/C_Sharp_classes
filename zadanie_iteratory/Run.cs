using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_iteratory
{
    internal class Run : Numbers
    {
        public Run()
        {
            Console.WriteLine($"Ilość liczb nieparzystych w tablicy: {Count()}");

            Console.Write($"Liczby nieparzyste w tablicy: ");
            Show();
        }
    }
}
