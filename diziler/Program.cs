using System.Globalization;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi-Array
            //int number = 10;
            //int[] numbers= new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;//IndexOutOfException

            //int[] numbers = {50,20,30};

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Sort(numbers);
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Console.WriteLine("How many names do you want to sort?");
            //byte sayi = byte.Parse(Console.ReadLine());
            //string[] names = new string[sayi];
            //for (int i = 0; i <names.Length; i++) 
            //{

            //    Console.Write($"Enter {i+1}. Name: "); 
            //    names[i] = Console.ReadLine();
            //}
            //Array.Sort(names);
            //for (int i = 0;i < names.Length;i++) { 
            //Console.WriteLine($"{i+1}-{names[i]}");
            //}

            //Console.WriteLine("How many numbers do you want to sort?");
            //int sayi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter starting number:");
            //byte baslangic = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number number:");
            //int bitis = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] sayilar = new int[sayi];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] =rnd.Next(baslangic,bitis);
            //}
            //Array.Sort(sayilar);
            //for (int i = 0;i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Generated random numbers must be unique
            Console.WriteLine("How many numbers do you want to sort?");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            byte baslangic = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number number:");
            int bitis = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Random rnd = new Random();

            HashSet<int> uniqueNumbers = new HashSet<int>();
            //hashset  içinde her elemandan 1 tane tutar
            //int değerlerini tutmasını istediğimiz için <int> yazıyoruz birbirinden farklı türde değer tutmak isteseydik object kullanacaktık HashSet in içindeki öğeleri ayırmak için de foreach döngüsü kullanıyoruz.
            
            while (uniqueNumbers.Count < sayi)
            {
                uniqueNumbers.Add(rnd.Next(baslangic, bitis));
            }
            //benzersiz numaraların sayısı istenen sayıdan az olmak şartıyla her seferinde içine random oluşturulan sayıları ekliyor 

            int[] sayilar = uniqueNumbers.ToArray();
            // uniqueNumbers'taki sayıları sayılar array'ine aktarıyor

            Array.Sort(sayilar);
            //array'deki sayıları sıralıyor

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

        }
    }
}
// Numbers: referans -> Heap bölgesindeki değerlerin adresini tutan yapılardır
// Index: Dizi elemanlarına ulaşmak için kullanılan sayılar. Index'ler 0'dan başlar