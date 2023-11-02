//Console.WriteLine("Birinci sayıyı giriniz");
//byte num1 = byte.Parse(Console.ReadLine());
//Console.WriteLine("İkinci sayıyı giriniz");
//byte num2 = byte.Parse(Console.ReadLine());
//if (num1>num2) 
//{
//    Console.WriteLine("Sayı 1 büyüktür");
//}
//else if (num1<num2)
//{
//    Console.WriteLine("Sayı 2 büyüktür");
//}
//else
//{
//    Console.WriteLine("Sayılar eşittir");
//}



Console.WriteLine("Dil Seçiniz/Chose Language EN/TR");
string language = Console.ReadLine();
if (language=="EN")
{
    Console.WriteLine("Enter the first number");
    double s1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    double s2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Select action: +, -, /, *");
    char islem = char.Parse(Console.ReadLine());

    string msg1 = "Result of the operation:";

    if (islem == '+')
    {
        Console.WriteLine($"{msg1} {s1 + s2}");
    }
    else if (islem == '-')
    {
        Console.WriteLine($"{msg1} {s1 - s2}");
    }
    else if (islem == '/')
    {
        Console.WriteLine($"{msg1} {s1 / s2}");
    }
    else if (islem == '*')
    {
        Console.WriteLine($"{msg1} {s1 * s2}");
    }
    else
    {
        Console.WriteLine("Incorrect operation");
    }

}
else if (language=="TR")
{
    Console.WriteLine("Birinci sayıyı giriniz");
    double s1 = double.Parse(Console.ReadLine());
    Console.WriteLine("İkinci sayıyı giriniz");
    double s2 = double.Parse(Console.ReadLine());

    Console.WriteLine("İşlem Seçiniz: +, -, /, *");
    char islem = char.Parse(Console.ReadLine());

    string msg = "İşlemin sonucu:";

    if (islem == '+')
    {
        Console.WriteLine($"{msg} {s1 + s2}");
    }
    else if (islem == '-')
    {
        Console.WriteLine($"{msg} {s1 - s2}");
    }
    else if (islem == '/')
    {
        Console.WriteLine($"{msg} {s1 / s2}");
    }
    else if (islem == '*')
    {
        Console.WriteLine($"{msg} {s1 * s2}");
    }
    else
    {
        Console.WriteLine("Hatalı işlem yaptınız");
    }

}
else
{
    Console.WriteLine("Bilinmeyen dil lütfen EN veya TR değerlerini giriniz. / Unknown language please enter EN or TR values.");
}
