using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Introduceti un numar");
            sbyte i0 = 0, i1 = 0, i2 = 0, i3 = 0, i4 = 0, i5 = 0, i6 = 0, i7 = 0, i8 = 0, i9 = 0, p = 0;
            long n = long.Parse(Console.ReadLine());
            while (n != 0)
            {
                switch (n % 10)
                {
                    case 0: if (i0 == 0) { i0++; p++; } break;
                    case 1: if (i1 == 0) { i1++; p++; } break;
                    case 2: if (i2 == 0) { i2++; p++; } break;
                    case 3: if (i3 == 0) { i3++; p++; } break;
                    case 4: if (i4 == 0) { i4++; p++; } break;
                    case 5: if (i5 == 0) { i5++; p++; } break;
                    case 6: if (i6 == 0) { i6++; p++; } break;
                    case 7: if (i7 == 0) { i7++; p++; } break;
                    case 8: if (i8== 0) { i8++; p++; } break;
                    case 9: if (i9 == 0) { i9++; p++; } break;
                }
                if (p > 2) break;
                n /= 10;
            }
            if (p == 2)
                Console.WriteLine("numarul este format din doua cifre repetabile");
            else
                Console.WriteLine("numarul nu este format din doua cifre repetabile");

        }
    }
}
