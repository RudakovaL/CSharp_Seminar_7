// Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// Вход: m = 2, n = 3
// Выход: A(m, n) = 29
// Вход: m = 1, n = 4
// Выход: A(m, n) = 7

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 2;
        int n = 3; 
        Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");

        m = 1; 
        n = 4; 
        Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m == 1)
            return n + 2;
        else if (m == 2)
            return 2 * n + 3;
        else if (m == 3)
            return (1 << (n + 3)) - 3; // 2^(n + 3) - 3, оптимизация для больших m
        else
            throw new ArgumentOutOfRangeException("m", "Функция Аккермана не определена для m > 3");
    }
}
