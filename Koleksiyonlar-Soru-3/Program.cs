using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sesliHarf = "aeıioöuü" ;
            ArrayList sesliler = new ArrayList();
            Console.Write("Bir cümle giriniz : ");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i ++)
            {
                if (sesliHarf.Contains(str[i]))
                {
                    sesliler.Add(str[i].ToString());
                }
            }
            foreach (var item in sesliler)
            {
                Console.WriteLine(item);
            }
        }
    }
}