using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stos<int> stosLiczbowy = new Stos<int>();
            stosLiczbowy.Push(1);
            stosLiczbowy.Push(2);
            stosLiczbowy.Push(3);
            stosLiczbowy.Push(4);
            stosLiczbowy.Pop();
            stosLiczbowy.Show();
        }
    }
}
