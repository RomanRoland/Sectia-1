using System;

namespace _10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            if (prim) { Console.WriteLine("numarul este prim"); }
            else { Console.WriteLine("numarul nu este prim"); }
        }
    }
}
