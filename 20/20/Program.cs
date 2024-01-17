using System;

namespace _20
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti impartitul si impartitorul (separarea se face prin ENTER)");
            int m =int.Parse(Console.ReadLine());
            int n =int.Parse(Console.ReadLine());
            sbyte p1 = 0, p2 = 0;
            double m1 = m;
            if (m % 2 != 0 && m % 5 != 0)
            {
                if (m % n == 0 && m / n == 0)
                {
                    Console.WriteLine((double)m / (double)n);
                }
                else
                {
                    int nr = (m % n)*10;
                    int r = nr / n;
                    int nr2 = (nr % n)*10;
                    while (true)
                    {
                        if (nr == nr2)
                        {
                            Console.WriteLine($"{m / n}.({r})/1");
                            break;
                        }
                        else
                        {
                            r = r * 10 + nr2 / n;
                            nr2 = (nr2 / n) * 10;
                            if (nr2 == 0)
                            {
                                Console.WriteLine($"{m / n}.{r/10}/2");
                                break;
                            }
                        }
                    }
                }

            }
            else
            {
                while (m1 % 2 == 0)
                {
                    p1++;
                    m1 /= 2;
                }
                while (m1 % 5 == 0)
                {
                    p2++;
                    m1 /= 5;
                }
                if (m1 == 1 && p1 == m && p2 == n)
                {
                    Console.WriteLine((double)(m / n));
                }
                else
                {
                    if (m % n == 0 && m / n == 0)
                    {
                        Console.WriteLine((double)(m / n));
                    }
                    else
                    {
                        int nr = (m % n) * 10;
                        int r = nr / n;
                        int nr2 = (nr % n) * 10;
                        while (true)
                        {
                            if (nr == nr2)
                            {
                                Console.WriteLine($"{m / n}.({r})/3");
                                break;
                            }
                            else
                            {
                                r = r * 10 + nr2 / n;
                                Console.WriteLine(r);
                                nr2 = (nr2 / n) * 10;
                                if (nr2 == 0)
                                {
                                    Console.WriteLine($"{m / n}.{r / 10}/4");
                                    break;
                                }
                                Console.WriteLine(r);
                            }
                        }
                    }
                    Console.WriteLine("caz periodica mixta" + " " + (double)(m/n));
                }
            }
        }
    }
}
