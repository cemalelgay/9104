using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanim
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}
            //Console.ReadKey();
            #endregion

            #region WhileFor
            //int n = 10, fakto = 1, counter = 1;

            //while (counter <= n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}

            //Console.WriteLine(fakto);

            //Console.ReadKey();

            /* ********* FORCA ********** */

            //int n = 5, fakto = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    fakto *= i;
            //}

            //Console.WriteLine(fakto);

            //Console.ReadLine();
            #endregion

            #region BirdenFazlaKontrol
            //bool durum = true;
            //for (int i = 0; durum == true && i < 100; i++)
            //{
            //    if (i * 2 > 20)
            //    {
            //        durum = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} iken devam ediyorum", i);
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region BreakContinue

            //for (int i = 0; i < 100; i = i + 5)
            //{
            //    if ( i * 2 < 20)
            //    {
            //        //break; //döngüyü sonlandırır
            //        continue; // bir sonraki değere geçirir
            //    }
            //    Console.WriteLine("{0} iken devam ediyorum", i);
            //}
            //Console.ReadKey();
            #endregion

            #region [1,n]aralığındakiSayilarinToplamı

            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    toplam += i;
            //    Console.WriteLine("i : {0} \t Toplam : {1}", i, toplam);
            //}

            //Console.WriteLine("Genel Toplam : " + toplam);
            //Console.ReadKey();

            #endregion

            #region İcİceFor
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region Harfler
            //for (char c = 'a'; c <= 'z'; c++)
            //{
            //    Console.Write(c + " ");
            //}
            //Console.ReadKey();
            #endregion

            #region CarpimTablosu
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1}\t= {2}", i, j , i * j);
                }
                Console.WriteLine("*************");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
