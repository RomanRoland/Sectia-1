using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un numar n si cele doua  numere din interval a respectiv b");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0 && i >= a && i <=b)
                {
                    Console.WriteLine(i);
                }
            }
            if (n >= a && n <= b)
            {
                Console.WriteLine(n);
            }
        }
    }
}
