using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kelime = "Merhaba İzmir";

            //int sayi = 10;
            //sayi = sayi + 1;
            //sayi++;

            //int toplam;
            //toplam = 10;

            ////toplam = toplam + sayi;
            //toplam += sayi;

            //toplam -= sayi; // toplam = toplam - sayi;

            //toplam *= sayi; // toplam = toplam * sayi;

            //toplam /= sayi; // toplam = toplam / sayi;

            //Console.WriteLine(toplam);
            //Console.ReadKey();


            double num1 = 5, num2 = 20, num3 = 30;

            Console.WriteLine("Sayi 1 : {0} \nSayi 2 : {1} \nSayi 3 : {2}", num1, num2, num3);

            num1 += num2;
            num1 += num3;
            num3 += num1;

            num3 /= 3;
            num1 /= 2;
            num1 -= num2;

            Console.WriteLine("Sayi 1 : {0} \nSayi 2 : {1} \nSayi 3 : {2}", num1, num2, num3);

            num1 = num3 % num2;

            Console.ReadKey();
        }
    }
}
