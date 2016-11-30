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

            //Console.WriteLine("[1-10] bir sayi tuttum HAdi Bul Bakalım.");

            //Random rnd = new Random();
            //int rasgeleSayi = rnd.Next(1, 11);
            //int tahmin, counter = 0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("Tahminin Ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rasgeleSayi)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("\nTebrikler... {0}. adımda bildin", counter);
            //Console.ReadKey();
            #endregion

            #region KullanıcıDevaEtmekİstedigiSureceDevamEt

            //bool devam = true;

            //while (devam)
            //{
            //    Console.Write("Birinci Sayi: ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İkinci Sayi: ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İslem Sec: ");
            //    char islem = Convert.ToChar(Console.ReadLine());

            //    double sonuc;

            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;

            //        default:
            //            Console.WriteLine("Böyle bir işlem tipi yok!");
            //            sonuc = 0;
            //            break;
            //    }

            //    Console.WriteLine("Sonuc: " + sonuc);

            //    Console.WriteLine("Devam edelim mi? (evet)");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "evet")
            //    {
            //        devam = true;
            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}

            //Console.WriteLine("Görüşmek üzere");
            //Console.ReadKey();
            #endregion

            #region TabanDonusturme

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 0;
            //int basamak = 1;
            //while (sayi > 0)
            //{
            //    sonuc += (sayi % 2) * basamak;
            //    basamak *= 10;
            //    sayi /= 2;
            //}
            //Console.WriteLine(sonuc);
            //Console.ReadKey();
            #endregion

            #region TahminEtVer1.0.0.1
            //Console.WriteLine("[1-100] bir sayi tuttum Hadi Bul Bakalım.");

            //Random rnd = new Random();
            //int rasgeleSayi = rnd.Next(1, 101);
            //int tahmin, counter = 0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("Tahminin Ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin < rasgeleSayi)
            //    {
            //        Console.WriteLine("Daha büyük tahmin yap");
            //    }
            //    else if (tahmin > rasgeleSayi)
            //    {
            //        Console.WriteLine("Daha küçük tahmin yap");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("\nTebrikler... {0}. adımda bildin", counter);
            //Console.ReadKey();
            #endregion

            #region TekÇift
            //long toplam = 0, carpim = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //string secim = Console.ReadLine();

            //int counter = 1;
            //while (counter <= n)
            //{
            //    if (counter % 2 == 1)
            //    {
            //        toplam += counter;
            //        carpim *= counter;
            //    }
            //    counter++;
            //}

            //if (secim == "topla")
            //{
            //    Console.WriteLine(toplam);
            //}
            //else if(secim == "carp")
            //{
            //    Console.WriteLine(carpim);
            //}
            //else
            //{
            //    Console.WriteLine(secim + " Ne ?? ");
            //}
            //Console.ReadKey();
            #endregion

        }
    }
}
