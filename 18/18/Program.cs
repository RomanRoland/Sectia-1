using System;

namespace _18
{
    internal class Program
    {
        static int Prim (int n)
        {
            n++;
            while (true)
            {
                int m = n;
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        n++;
                        break;
                    }
                }
                if (n == m)
                {
                    return m;
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int d = 2, p = 0;
            while (n != 1)
            {
                if (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                else
                {
                    if (p > 0)
                    {
                        Console.Write($"{d} ^ {p} x ");
                        p = 0;
                        d = Prim(d);
                    }
                    else
                    {
                        d= Prim(d);
                    }
                }
            }
            Console.Write($"{d} ^ {p} ");
        }
    }
}
