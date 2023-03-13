using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararVeDonguOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string d = "";
            //bool e = true;
            //int a = 34;
            //int b = 50;
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(default(int));
            //Console.ReadLine();




            //int sayac = 1;

            //do
            //{
            //    Console.WriteLine($"{0}. Bilge Adam",sayac);
            //    sayac++;

            //} while (sayac<=10);

            //Console.ReadLine();


            //alternatif

            #region Farklı şekillerde cw yapma

            //int sayac = 1;

            //do
            //{
            //    //Console.WriteLine("{0}. Bilge Adam", sayac<10 ? $"0{sayac}" : $"{sayac}");
            //    Console.WriteLine("{0} Bilge Adam", sayac.ToString().PadLeft(2, '0'));

            //    sayac++;

            //} while (sayac <= 10);

            //Console.ReadLine();

            #endregion


            #region Örnek2

            // Klavyeden girilen sayıya kadar olan tüm sayıların toplamını bulan program

            //int sayi, toplam = 0;
            //Console.WriteLine("Sayı giriniz");
            //sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i < sayi; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Sonuc= " + toplam);
            //Console.ReadLine();


            #endregion



            /*
             *  Sayı Giriniz=10
             **
             ***
             ****
             *****
             ******
             */


            Console.WriteLine("sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)  //satırlar için dönecek
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();

            //durmus
            //Bu satır durmus tarafından yazıldı
            //Dursay yeni gelistirme



        }
    }
}
