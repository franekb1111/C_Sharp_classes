using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TablicaGeneryczna<int> tablica = new TablicaGeneryczna<int>(4);
            tablica.Set_value(0, 1);
            tablica.Set_value(1, 2);
            tablica.Set_value(2, 3);
            tablica.Set_value(3, 4);

            tablica.Get_value(0);
            tablica.Get_value(1);
            tablica.Get_value(2);
            tablica.Get_value(3);
        }
    }
}
