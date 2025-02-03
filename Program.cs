using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");

        var name = Console.ReadLine();

        Console.WriteLine("Ваше имя по буквам: ");

        foreach (var ch in name)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine("Первая буква вашего имени: {0}", name[0]);

        Console.ReadKey();
    }
}