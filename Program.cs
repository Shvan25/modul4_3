﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                Console.Write(array[i, k] + " ");

            Console.WriteLine();
        }
    }
}