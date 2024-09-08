// : Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// Вход: M = 1, N = 5
// Выход: 1, 2, 3, 4, 5
// Вход: M = 4, N = 8
// Выход: 4, 5, 6, 7, 8

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int M, int N)
    {
        if (M > N) return; 
        Console.Write(M + " "); 
        PrintNaturalNumbers(M + 1, N); 
    }
}
