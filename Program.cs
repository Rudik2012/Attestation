// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1.
//   Выполнить с помощью рекурсии.


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         PrintNumbers(n);

//         Console.ReadKey();
//     }

//     static void PrintNumbers(int n)
//     {
//         if (n <= 0)
//             return;

//         Console.Write(n + ", ");
//         PrintNumbers(n - 1);
//     }
// }


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int M = 1;
//         int N = 15;

//         int sum = 0;
//         for (int i = M; i <= N; i++)
//         {
//             sum += i;
//         }

//         Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1}: {2}", M, N, sum);
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

        m = 3;
        n = 2;
        result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }
}
