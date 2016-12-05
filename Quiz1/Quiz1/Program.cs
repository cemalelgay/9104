using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10; //bu sayıya kadar, 1 den itibaren toplama yapacağım
            //int sayac = 1, toplam = 0;

            //while (sayac <= n)
            //{
            //    toplam += sayac;
            //    sayac++;
            //}

            //Console.WriteLine(toplam);

            //Console.Write("Tersten: ");

            //while (n > 0)
            //{
            //    Console.Write(n + " ");
            //    n--;
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.Write(i + " ");
            //}


            // Kare
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == 0 || i == 4 || j == 0 || j == 4)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Dikdörtgen
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if (i == 0 || i == 4 || j == 0 || j == 7)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Paralelkenar
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == 0 && j >= 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    if (i == 1 && (j == 1 || j == 4))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    if (i == 2 && j <= 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
