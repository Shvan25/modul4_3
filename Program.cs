using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int sum = 0;

        foreach (int i in arr)
        {
            sum += i;
        }

        Console.WriteLine(sum);

    }
}