// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // здесь можно задать значение N
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        Console.Write(n + " ");
        if (n > 1)
        {
            PrintNumbers(n - 1);
        }
    }
}