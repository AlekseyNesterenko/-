/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string GetNumbersRecurtion(int m, int n)
{
    if (m == n) return $"{n}";
    else return m + " " + GetNumbersRecurtion(m + 1, n);
}

int GetSumRecurtion(int m, int n)
{
    if (m == n) return n;
    else return m + GetSumRecurtion(m + 1, n);
}

string numbersRow = GetNumbersRecurtion(m, n);
Console.WriteLine($"Числа от M до N: {numbersRow}");

int sum = GetSumRecurtion(m, n);
Console.WriteLine($"Сумма чисел от M до N: {sum}");