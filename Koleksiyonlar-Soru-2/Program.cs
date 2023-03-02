using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiListesi = new int[5];
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            List<int> asalListe = new List<int>();
            List<int> asalOlmayanListe = new List<int>();

            Console.WriteLine("5 adet sayı giriniz !");
            for (int i = 0; i < 5; i++)
            {
                bool sayiMi = false;
                Console.Write("Sayı : ");
                string str = Console.ReadLine();

                while(sayiMi == false) {
                    try
                    {
                        int.Parse(str);
                        while (int.Parse(str) <= 0)
                        { 
                            sayiMi = false;
                            Console.Write("Pozitif bir sayı giriniz : ");
                            str = Console.ReadLine();
                        }
                        sayiMi = true;
                        sayiListesi[i] = int.Parse(str);
                    }
                    catch (Exception)
                    {
                        sayiMi = false;
                        Console.Write("Geçersiz değer girişi !\nTekrar deneyiniz : ");
                        str = Console.ReadLine();
                    }
                }         
            }

            foreach (var item in sayiListesi)
            {
                int x = 0;
                if (item == 1)
                {
                    asalOlmayanListe.Add(item);
                    continue;
                }
                else if (item != 1)
                {
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            x++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                     
                if (x == 0)
                {
                    asalListe.Add(item);
                }
                else
                {
                    asalOlmayanListe.Add(item);
                }
            }
            Console.WriteLine("--- ASAL LİSTE ---");
            asalListe.Sort();
            foreach (var item in asalListe)
            {
                Console.WriteLine(item);
                asalToplam += item;
            }
            Console.WriteLine("Asal listenin eleman sayısı : " + asalListe.Count);
            Console.WriteLine("Asal liste ortalaması : " + asalToplam / asalListe.Count);
            Console.WriteLine("--------------------");

            Console.WriteLine("--- ASAL OLMAYAN LİSTE ---");
            asalOlmayanListe.Sort();
            foreach (var item in asalOlmayanListe)
            {
                Console.WriteLine(item);
                asalOlmayanToplam += item;   
            }
            Console.WriteLine("Asal listenin eleman sayısı : " + asalOlmayanListe.Count);
            Console.WriteLine("Asal liste ortalaması : " + asalOlmayanToplam / asalOlmayanListe.Count);
        }
    }
}