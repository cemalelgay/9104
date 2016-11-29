using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [0,9] sayilari yaz
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //Console.ReadKey();
            #endregion

            #region FaktoriyelHesaplama

            //int n = 10, fakto = 1, counter = 1;

            //while (counter <= n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}

            //Console.WriteLine(fakto);

            //Console.ReadKey();

            #endregion


            #region TahminEt

            Console.WriteLine("[1-10] bir sayi tuttum HAdi Bul Bakalım.");

            Random rnd = new Random();
            int rasgeleSayi = rnd.Next(1, 11);
            int tahmin, counter = 0;

            while (true)
            {
                counter++;
                Console.Write("Tahminin Ne: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == rasgeleSayi)
                {
                    break;
                }
            }
            Console.WriteLine("\nTebrikler... {0}. adımda bildin", counter);
            Console.ReadKey();
            #endregion
        }
    }
}
