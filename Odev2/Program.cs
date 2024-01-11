namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to sort?");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            byte baslangic = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number number:");
            int bitis = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Random rnd = new Random();

            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < sayi)
            {
                uniqueNumbers.Add(rnd.Next(baslangic, bitis));
            }

            int[] sayilar = uniqueNumbers.ToArray();

            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}