using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduceti un numar");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numarului n sunt:");
            for (int i = 1; i <= (int)(n/2); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(n);
        }
    }
}
