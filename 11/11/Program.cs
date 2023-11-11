using System;

namespace _11
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine(n % 10);
                n = n / 10;
            }
        }
    }
}
