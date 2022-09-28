/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

Console.Write("Введите положительное число m: ");
long m = long.Parse(Console.ReadLine());

Console.Write("Введите положительное число n: ");
long n = long.Parse(Console.ReadLine());

long FindAckermannFunction(long m, long n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FindAckermannFunction(m - 1, 1);
    else return FindAckermannFunction(m - 1, FindAckermannFunction(m, n - 1));
}




long result = FindAckermannFunction(m, n);
Console.WriteLine($"A({m},{n})= {result}");