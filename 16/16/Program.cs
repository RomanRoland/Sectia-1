using System;

namespace _16
{
    internal class Program
    {
        static void Sort(ref int a,ref int b)
        {
            if (a > b)
            {
                a += b;
                b = a - b;
                a = a - b;
            }
        }
        static void Main()
        {
            Console.WriteLine("Introduceti 5 numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            Sort(ref a, ref b);
            Sort(ref a, ref c);
            Sort(ref a, ref d);
            Sort(ref a, ref e);
            Sort(ref b, ref c);
            Sort(ref b, ref d);
            Sort(ref b, ref e);
            Sort(ref c, ref d);
            Sort(ref c, ref e);
            Sort(ref d, ref e);
            Console.WriteLine(a + " " + b + " " + c + " " + d + " "  + e);
        }
    }
}
