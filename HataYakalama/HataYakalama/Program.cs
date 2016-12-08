using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[4];
            //Console.WriteLine(array[5]);

            //try
            //{
            //    int[] array = new int[4];
            //    Console.WriteLine(array[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Böyle bir dizin yok");
            //}

            //try
            //{
            //    int sayi = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally çalıştı.");
            //}

            //try
            //{
            //    int sayi = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally çalıştı.");
            //}

            //try
            //{
            //    int sayi = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    
            //}

            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
