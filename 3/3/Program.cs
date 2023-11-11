using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti doua numere la care se va verifica divizibilitatea");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n%k == 0) { Console.WriteLine("numerele sunt divizibile"); }
            else { Console.WriteLine("numerele nu sunt divizibile"); }
        }
    }
}
