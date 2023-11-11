using System;

namespace _1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti doua numere in care se va rezolva ecuatia de gradul I(a si b) unde a+b=0");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine((-a) / b);
        }
    }
}
