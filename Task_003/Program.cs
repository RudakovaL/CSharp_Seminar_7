// : Реализуйте рекурсивную функцию Аккермана, основываясь на её
// определении:
// A(0,n)=n+1A(0, n) = n + 1A(0,n)=n+1
// A(m,0)=A(m−1,1)A(m, 0) = A(m - 1, 1)A(m,0)=A(m−1,1)
// A(m,n)=A(m−1,A(m,n−1))A(m, n) = A(m - 1, A(m, n - 1))A(m,n)=A(m−1,A(m,n−1))

using System;

class Program
{
    static void Main()
    {
        int m = 2; 
        int n = 3; 
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m == 1)
        {
            return n + 2;
        }
        else if (m == 2)
        {
            return 2 * n + 3;
        }
        else if (m == 3)
        {
            return int.MaxValue; 
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}