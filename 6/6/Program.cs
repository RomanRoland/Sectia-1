using System;

namespace _6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduceti lungimea celor 3 laturi");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Acestea pot forma un triunghi");
            else
                Console.WriteLine("Acestea nu pot forma un triunghi");
        }
    }
}
