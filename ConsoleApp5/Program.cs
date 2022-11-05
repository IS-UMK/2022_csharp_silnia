using System;

namespace ProgramSilnia
{
    class Program
    {
        static int Silnia(int n)
        {
            int s = 1;

            for (int i = 2; i <= n; i++)
            {
                s = s * i;
            }
            return s;
        }

        static int SilniaRekurencja(int n)
        {
            if (n < 2) return 1;
            return SilniaRekurencja(n - 1) * n;
        }

        public static void Main()
        {
            int n;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int s = Silnia(i);
                Console.WriteLine("Silnia z {0} wynosi {1}", i, s);
            }

            Console.WriteLine("To samo wykorzystując wersję rekurencyjną");
            for (int i = 1; i <= n; i++)
            {
                int s = SilniaRekurencja(i);
                Console.WriteLine("Silnia z {0} wynosi {1}", i, s);
            }
        }
    }
}
