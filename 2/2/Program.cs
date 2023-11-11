using System;

namespace _2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti trei numere a, b respectiv c la care se va rezolva ecuatia de gradul 2");
            float a = float.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) { Console.WriteLine("ecuatia nu are solutii"); }
            if (d == 0) { Console.WriteLine($"Ecuatia are doar o solutie:x={(-b) / (2 * a)}"); }
            if (d > 0) 
            { 
                Console.WriteLine($"Ecuatia are doua solutii: x1={((-b)+Math.Sqrt(d))/(2*a)} x2={((-b)-Math.Sqrt(d))/(2*a)}");
            }
        }
    }
}
