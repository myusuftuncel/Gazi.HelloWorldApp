using System.Reflection.Emit;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(10);
            int min = 1;
            int max = 100;
            string msg1 = "Sayıyı tahmin ediniz";
            string msg3 = "Tebrikler orta seviyeye geçtiniz";
            string msg2 = "Tekrar deneyiniz\n";
            string msg4 = "Tebrikler zor seviyeye geçtiniz";
            string msg5 = "Tebrikler kazandınız!";
            double sayac = 0;
            int puan = 100;
            int level = 1;
            Console.WriteLine(msg1);
            int kullanicigirisi = int.Parse(Console.ReadLine());
        
            while (true)
            {
                if (kullanicigirisi == number)
                {
                    Console.WriteLine(msg3);
                    level++;
                    number = rnd.Next(20);
                    if (level==2)
                    {
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Üzgünüm, yanlış tahmin. Lütfen tekrar deneyin.");

                    puan = puan-1;
                    if (kullanicigirisi < number)
                    {
                        Console.WriteLine("Daha büyük bir sayı girin.");
                        min = kullanicigirisi + 1;
                    }
                    else
                    {
                        Console.WriteLine("Daha küçük bir sayı girin.");
                        max = kullanicigirisi - 1;
                    }
                    kullanicigirisi = int.Parse(Console.ReadLine());
                }
                if (puan <= 30)
                {
                    Console.WriteLine($"Kaybettiniz Puanınız:{puan}");
                    break;
                }

            }
                
            
        }
    }
}