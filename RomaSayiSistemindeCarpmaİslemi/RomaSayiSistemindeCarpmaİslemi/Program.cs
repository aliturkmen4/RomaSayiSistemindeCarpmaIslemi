using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaSayiSistemindeCarpmaİslemi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int sonuc = 0;
            Console.WriteLine("1. sayıyı giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz.");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 % 2 != 0)/* ilk girilen sayı tek yada çif olabilir o durumun kontrolü*/
            {
                sonuc = sayi2;
                Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=" + sonuc);
                sayi1 = sayi1 / 2;
            }
            else
            {
                sonuc = 0;
                Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=sonuc değerine atama yok.");
                sayi1 = sayi1 / 2;
            }


        baslangic:
            /* sayi1 = sayi1 / 2;*/


            if (sayi1 != 1 && sayi1 >= 1)
            {
                if (sayi1 % 2 != 0)/* sayi1 tek sayi*/
                {
                    sayi2 = sayi2 * 2;
                    sonuc = sonuc + sayi2;
                    Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=" + sonuc);
                    sayi1 = sayi1 / 2;
                    goto baslangic;

                }
                else/*sayi1 çift sayi*/
                {
                    sayi2 = sayi2 * 2;
                    Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=sonuc değerine atama yok. " + sonuc);
                    sayi1 = sayi1 / 2;
                    goto baslangic;

                }

            }
            else if (sayi1 == 1)
            {

                sayi2 = sayi2 * 2;
                sonuc = sonuc + sayi2;
                Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=" + sonuc);
                sayi1 = sayi1 / 2;
            }
            Console.ReadLine();

            //2.çözüm

            int a, b, toplam = 0;
            Console.Write("1.sayıyı giriniz:");
            a = int.Parse(Console.ReadLine());
            Console.Write("2.sayı giriniz:");
            b = int.Parse(Console.ReadLine());
            if (a % 2 != 0 || a != 1)
            {
                toplam += b;
            }
            while (a != 1)
            {
                Console.WriteLine($"1. sayı:  {a}  2.sayı: {b}");
                a = a / 2;
                b = b * 2;
                if (a % 2 != 0)
                {
                    toplam += b;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
