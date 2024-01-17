using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti doi ani");
            int y1 = int.Parse(Console.ReadLine()) + 1;
            int y2 = int.Parse(Console.ReadLine());
            if (y1 > y2)
            {
                y1 = y1 + y2;
                y2 = y1 - y2;
                y1 = y1 - y2;
            }
            while (true)
            {
                if (y1 % 4 == 0 && y1 % 100 != 0 || y1 % 400 == 0)
                {
                    break;
                }
                y1++;
            }
            do
            {
                if (y1 % 4 == 0 && y1 % 100 != 0 || y1 % 400 == 0)
                    Console.WriteLine(y1);
                y1 += 4;
            } while (y1 < y2);
        }
    }
}
