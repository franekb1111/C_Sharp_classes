using System;
using zadanie_1;

namespace Typyog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Para<int, double> test = new Para<int, double>(3, 2.45);
            Console.WriteLine(test);
        }
    }
}
