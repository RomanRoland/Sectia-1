using System;

namespace _4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un an");
            int an = int.Parse(Console.ReadLine());
            if (an % 4 == 0) { Console.WriteLine("Anul este bisect"); }
            else { Console.WriteLine("Anul nu este bisect"); }
        }
    }
}
