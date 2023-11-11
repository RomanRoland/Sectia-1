using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti 3 numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (b < c) {Console.WriteLine(a + " " + b + " " + c);}
                else
                {
                    if (c < a) { Console.WriteLine(c + " " + a + " " + b);}
                    else { Console.WriteLine(a + " " + c + " " + b); }
                }
            }
            else
            {
                if (c > a) { Console.WriteLine(b + " " + a + " " + c); }
                else
                {
                    if (c > b) { Console.WriteLine(b + " " + c + " " + a); }
                    else { Console.WriteLine(c + " " + b + " " + a); }
                }
            }
        }
    }
}
