namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiList = new int[4];
            Console.WriteLine("20 adet pozitif sayı giriniz.");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Sayı : ");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                if(girilenSayi <= 0)
                {
                    Console.Write("Geçersiz sayı girişi yaptınız. \nYeni sayı giriniz : ");
                    girilenSayi = Convert.ToInt32(Console.ReadLine());    
                }
                else
                {

                    sayiList[i] = girilenSayi;
                }

            }
            foreach (var item in sayiList)
            {
                Console.WriteLine(item);
            }
        }
    }
}