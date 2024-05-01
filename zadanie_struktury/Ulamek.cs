using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_struktury
{
    public struct Ulamek
    {
        private int licznik;
        private int mianownik;

        public int Licznik
        {
            get { return licznik; }
            set { licznik = value; }
        }

        public int Mianownik
        {
            get { return mianownik; }
            set { mianownik = value; }
        }

        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public static Ulamek Uprosc(Ulamek u)
        {
            int nwd = NajwiekszyWspolnyDzielnik(u.licznik, u.mianownik);
            return new Ulamek(u.licznik / nwd, u.mianownik / nwd);
        }

        private static int NajwiekszyWspolnyDzielnik(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            int nowyMianownik = u1.Mianownik * u2.Mianownik;
            int nowyLicznik = u1.Licznik * u2.Mianownik + u2.Licznik * u1.Mianownik;
            return Uprosc(new Ulamek(nowyLicznik, nowyMianownik));
        }

        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            int nowyMianownik = u1.Mianownik * u2.Mianownik;
            int nowyLicznik = u1.Licznik * u2.Mianownik - u2.Licznik * u1.Mianownik;
            return Uprosc(new Ulamek(nowyLicznik, nowyMianownik));
        }

        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            return Uprosc(new Ulamek(u1.Licznik * u2.Licznik, u1.Mianownik * u2.Mianownik));
        }

        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            return Uprosc(new Ulamek(u1.Licznik * u2.Mianownik, u1.Mianownik * u2.Licznik));
        }

        public static bool operator ==(Ulamek u1, Ulamek u2)
        {
            return u1.Licznik * u2.Mianownik == u2.Licznik * u1.Mianownik;
        }

        public static bool operator !=(Ulamek u1, Ulamek u2)
        {
            return !(u1 == u2);
        }

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return u1.Licznik * u2.Mianownik > u2.Licznik * u1.Mianownik;
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            return u1.Licznik * u2.Mianownik < u2.Licznik * u1.Mianownik;
        }

        public static bool operator >=(Ulamek u1, Ulamek u2)
        {
            return u1.Licznik * u2.Mianownik >= u2.Licznik * u1.Mianownik;
        }

        public static bool operator <=(Ulamek u1, Ulamek u2)
        {
            return u1.Licznik * u2.Mianownik <= u2.Licznik * u1.Mianownik;
        }

        public static Ulamek operator +(Ulamek u)
        {
            return u; 
        }

        public static Ulamek operator -(Ulamek u)
        {
            return new Ulamek(-u.Licznik, u.Mianownik);
        }

        public override bool Equals(object? obj)
        {
            return obj is Ulamek u2 && this.licznik == u2.licznik && this.mianownik == u2.mianownik;
        }


        public override string ToString()
        {
            return $"{licznik}/{mianownik}";
        }

    }
}
