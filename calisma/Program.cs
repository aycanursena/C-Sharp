using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;

namespace calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Response resp = new Response();
            //resp.First();
            //resp.Second();
            resp.Third();
        }
    }

    public class Response
    {
        public void First()
        {
            
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi <= 0)
            {
                Console.WriteLine("Geçersiz sayı girdiniz !! \nLütfen pozitif bir sayı giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
            }

            int[] girilenSayilar = new int[sayi];
            Console.WriteLine(sayi + " adet sayı giriniz :");

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Sayı : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                girilenSayilar[i] = sayi2;           
            }

            Console.WriteLine("Girilen çift sayılar : ");
            foreach (var item in girilenSayilar)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Second()
        {
            Console.Write("Pozitif sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi <= 0)
            {
                Console.Write("Geçersiz sayı. Pozitif bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Pozitif sayı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            while (sayi2 <= 0)
            {
                Console.Write("Geçersiz sayı. Pozitif bir sayı giriniz : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            int[] girilenSayilar = new int[sayi];
            Console.WriteLine(sayi + " adet pozitif sayı giriniz : ");
            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Sayı : ");
                int sayi3 = Convert.ToInt32(Console.ReadLine());
                girilenSayilar[i] = sayi3;
            }
            Console.WriteLine("--- ÇIKTI ---");
            foreach(var item in girilenSayilar)
            {
                if ((item % sayi2 == 0 ) || (item % sayi2 == 0)){
                    Console.WriteLine(item);
                }
            }
        }

        public void Third() 
        {
            Console.Write("Pozitif sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi <= 0)
            {
                Console.Write("Geçersiz sayı. Pozitif bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            string[] kelimeList = new string[sayi];
            Console.WriteLine(sayi + " adet kelime giriniz.");

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Kelime : ");
                String girilenKelime = Console.ReadLine();
                kelimeList[i] = girilenKelime;
            }

            Array.Reverse(kelimeList);
            foreach (var item in kelimeList)
            {
                Console.WriteLine(item);
            }
        }
    }
}