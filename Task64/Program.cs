﻿// Задача 64:Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

string GetNumbers(int n)
{
    if (n == 1) return "1";
    else return n + " " + GetNumbers(n - 1);
}

string numbersRow = GetNumbers(n);
Console.WriteLine($"Числа от n до 1: {numbersRow}");
