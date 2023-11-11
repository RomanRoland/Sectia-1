using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un numar si pozitia cifrei dorite");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int m = n,c1 = 0,l = 1;
            while (m != 0)
            {
                c1++;
                m = m / 10;
            }
            for (int i = 0; i < c1 - k; i++) { l = l * 10; }
            Console.WriteLine((n / l) % 10);
        }
    }
}
