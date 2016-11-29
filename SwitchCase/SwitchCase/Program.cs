using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Gunler
            //bas:
            //Console.Write("1-7 arası bir sayı girin: ");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("pazar");
            //        break;
            //    default:
            //        goto bas;
            //}

            //Console.ReadKey();
            #endregion

            #region Aylar
            //bas:
            //Console.Write("1-12 arası bir sayı girin: ");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 12:

            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış Giriş");
            //        break;
            //}

            //if (gun > 0)
            //{
            //    goto bas;
            //}
            #endregion

            #region DortIslem
            //double sayi1, sayi2;
            //char secim;

            //Console.Write("Birinci Sayi \t: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci Sayi \t: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //bas:
            //Console.Write("İşlem Seçiniz \t: ");
            //secim = Convert.ToChar(Console.ReadLine());

            //switch (secim)
            //{
            //    case '+':
            //        Console.WriteLine("Toplam \t: " + (sayi1 + sayi2));
            //        break;
            //    case '-':
            //        Console.WriteLine("Fark \t: " + (sayi1 - sayi2));
            //        break;
            //    case '*':
            //        Console.WriteLine("Çarpım \t: " + (sayi1 * sayi2));
            //        break;
            //    case '/':
            //        Console.WriteLine("Bölüm \t: " + (sayi1 / sayi2));
            //        break;

            //    default:
            //        Console.WriteLine("\nYanlış Bir Seçim Yaptınız \nLütfen Yeniden Seçim Yapın\n");
            //        goto bas; // Bilin ama kullanmayin :D
            //}
            //Console.ReadKey();
            #endregion

            #region MusteriHizmetleri
            Console.WriteLine("Merhaba, Lütfen yapmakistediğiniz işlemi Seçiniz...");
            Console.WriteLine("1. Lira Yükleme\n"+
                "2. İnternet Paketi\n"+
                "3. Konuşma Paketi");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Lira Yükleme Servisine Hoşgeldiniz");
                    break;

                case 2:
                    Console.WriteLine("İnternet Paketi Servisine Hoşgeldiniz");
                    break;

                case 3:
                    Console.WriteLine("Konuşma Paketi Servisine Hoşgeldiniz");
                    break;

                default:
                    Console.WriteLine("Müşteri Temsilcisine Yönlendiriliyorsunuz...");
                    break;
            }
            Console.ReadKey();
            #endregion

        }
    }
}
