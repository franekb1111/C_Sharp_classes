namespace zadanie_struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(3, 4);
            Ulamek u2 = new Ulamek(2, 7);
            Ulamek suma = u1 + u2;
            Ulamek roznica = u1 - u2;
            Ulamek iloczyn = u1 * u2;
            Ulamek iloraz = u1 / u2;
            Ulamek dodatni = +u1;
            Ulamek ujemny = -u1;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Różnica: {roznica}");
            Console.WriteLine($"Iloczyn: {iloczyn}");
            Console.WriteLine($"Iloraz: {iloraz}");
            Console.WriteLine($"Ulamek: {dodatni}");
            Console.WriteLine($"Ulamek ujemny: {ujemny}");

            Console.WriteLine($"Czy {u1} == {u2}? {u1 == u2}");
            Console.WriteLine($"Czy {u1} != {u2}? {u1 != u2}");
            Console.WriteLine($"Czy {u1} > {u2}? {u1 > u2}");
            Console.WriteLine($"Czy {u1} < {u2}? {u1 < u2}");
            Console.WriteLine($"Czy {u1} >= {u2}? {u1 >= u2}");
            Console.WriteLine($"Czy {u1} <= {u2}? {u1 <= u2}");
        }
    }
}