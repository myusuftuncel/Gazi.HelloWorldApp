namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(10);
            string msg1 = "Sayıyı tahmin ediniz";
            string msg3 = "Tebrikler orta seviyeye geçtiniz";
            string msg2 = "Tekrar deneyiniz\n";
            string msg4 = "Tebrikler zor seviyeye geçtiniz";
            string msg5 = "Tebrikler kazandınız!";
            double sayac = 0;
            int puan = 100;
            while (true)
            {
                Console.WriteLine(msg1);
                int sayi = int.Parse(Console.ReadLine());
                if (number != sayi)
                {
                    Console.WriteLine(msg2);
                    puan = puan - 1;
                }
                else
                {

                    {
                        Console.WriteLine(msg3);

                        Console.WriteLine($"Puanınız:{puan}");

                        if (number != sayi)
                        {
                            Console.WriteLine(msg2);
                            puan = puan - 3;
                        }
                        else
                        {
                            number = rnd.Next(20);
                            for (; ; )
                            {
                                Console.WriteLine(msg1);
                                sayi = int.Parse(Console.ReadLine());


                                Console.WriteLine(msg4);

                                Console.WriteLine($"Puanınız:{puan}");



                                number = rnd.Next(30);
                                for (; ; )
                                {
                                    if (number != sayi)
                                    {
                                        Console.WriteLine(msg2);
                                        puan = puan - 5;
                                    }
                                    else
                                    {
                                        Console.WriteLine(msg1);
                                        sayi = int.Parse(Console.ReadLine());


                                        Console.WriteLine(msg5);

                                        Console.WriteLine($"Puanınız:{puan}");
                                        break;
                                    }
                                }
                            }
                        }
                    }

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