using System;

namespace _17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti doua numere");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int a = n;
            int b = m;
            while (m != n)
            {
                if (m < n)
                    n -= m;
                else
                    m -= n;
            }
            Console.WriteLine("cmmdc= " + n);
            n = a; m = b;
            while (m != n)
            {
                if (n < m)
                    n += a;
                else
                    m += b;
            }
            Console.WriteLine("cmmmc= " + n);
        }
    }
}
