using System;

namespace _21
{
    internal class Program
    {
        static void Main()
        {
            int m=1, n=1024, s;
            Console.WriteLine("Ganditiva la un numar de la 1 la 1024 si eu o sa il ghicesc (introduceti orice sa continuati)");
            while (true)
            {
                
                    s = (m + n) / 2;
                    Console.WriteLine("Este numarul mai mare sau egal decat " + (m + n) / 2 + "?(y pentru da, n pentru nu)");
                    string i = Console.ReadLine();
                    if (i == "y")
                    {
                        m = s;
                    }
                    else
                    {
                        n = s - 1;
                    }
                    if (m == n)
                    {
                        Console.WriteLine($"Numarul este {m}");
                        break;
                    }
                if (m+1 == n)
                {
                    Console.WriteLine("Este numarul mai mare sau egal decat " + n + "?(y pentru da, n pentru nu)");
                    i = Console.ReadLine();
                    if (i == "y")
                    {
                        Console.WriteLine($"Numarul este {n}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Numarul este {m}");
                        break;
                    }
                }
;
            }
        }
    }
  
}
