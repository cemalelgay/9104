using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AnlamlıBirŞeyYaz
            //int sayi1 = 0, sayi2 = 5;

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayi1 büyük");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("Sayi2 Büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar Eşit");
            //}
            //Console.ReadKey();
            #endregion

            #region TekCift
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Tektir.");
            //}
            //Console.ReadKey();
            #endregion

            #region AtamaArttırma
            //int a = 5;
            ////int b = a++; // b=a; a++;
            //int b = ++a; // a++; b=a;

            //Console.WriteLine(a + " - " + b);
            //Console.ReadKey();
            #endregion

            #region Dortİslem
            //int sayi1, sayi2;
            //char islem;
            //string sonuc;

            //Console.Write("Birinci Sayi \t: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci Sayi \t: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İslem Seciniz \t: ");
            //islem = Convert.ToChar(Console.ReadLine());

            //if (islem == '+')
            //{
            //    sonuc = (sayi1 + sayi2).ToString();
            //}
            //else if (islem == '-')
            //{
            //    sonuc = (sayi1 - sayi2).ToString();
            //}
            //else if (islem == '/')
            //{
            //    sonuc = (sayi1 / sayi2).ToString();
            //}
            //else if (islem == '*')
            //{
            //    sonuc = (sayi1 * sayi2).ToString();
            //}
            //else
            //{
            //    sonuc = "Hatalı İşlem";
            //}

            //Console.WriteLine("Sonuç \t\t: " + sonuc);

            //Console.ReadKey();
            #endregion

            #region GeçtiKaldı
            //int vize = Convert.ToInt32(Console.ReadLine());
            //int final = Convert.ToInt32(Console.ReadLine());

            //double sonuc = (vize * 0.4) + (final * 0.6);
            //Console.Write(sonuc + " ");

            //if (sonuc >= 85)
            //{
            //    Console.WriteLine("AA");
            //}
            //else if (sonuc >= 80 && sonuc <= 84)
            //{
            //    Console.WriteLine("BA");
            //}
            //else if (sonuc >= 75 && sonuc <= 79)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (sonuc >= 70 && sonuc <= 74)
            //{
            //    Console.WriteLine("CB");
            //}
            //else if (sonuc >= 60 && sonuc <= 69)
            //{
            //    Console.WriteLine("CC");
            //}
            //else
            //{
            //    Console.WriteLine("FF");
            //}
            //Console.ReadKey();
            #endregion

            #region Vergi
            int maas = Convert.ToInt32(Console.ReadLine());

            if (maas <= 1000)
            {
                Console.WriteLine("Vergi : {0}", maas * 0.1);
            }
            else if (maas <= 2500)
            {
                Console.WriteLine("Vergi : {0}", maas * 0.2);
            }
            else if (maas <= 5000)
            {
                Console.WriteLine("Vergi : {0}", maas * 0.3);
            }
            else
            {
                Console.WriteLine("Vergi : {0}", maas * 0.5);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
