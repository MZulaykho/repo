using System;

class Program
{
    static void Main(string[] args)
    {
        // Введите значения M и N
        int M = 1;
        int N = 10;

        // Вызов рекурсивной функции
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        // Базовый случай: N меньше или равно M
        if (N <= M)
        {
            return;
        }

        // Рекурсивный шаг: вывести N, затем рекурсивно вывести числа от M до N-1
        Console.WriteLine(N);
        PrintNumbers(M, N - 1);
    }
}