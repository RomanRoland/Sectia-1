using System;

namespace _14
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int m = n, i = 0;
            while (m != 0)
            {
                i = i * 10 + m % 10;
                m = m / 10;
            }
            if (i == n)
            {
               Console.WriteLine("numarul este palindrom");
            }
            else
            {
                Console.WriteLine("numarul nu este palindrom");
            }
        }
    }
}
