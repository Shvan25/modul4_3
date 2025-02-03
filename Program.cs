using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        Console.WriteLine(array.Length);

        Console.Write("Количество строк: ");
        Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

        Console.Write("Количество колонок: ");
        Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                Console.Write(array[i, k] + " ");

            Console.WriteLine();
        }
    }
}