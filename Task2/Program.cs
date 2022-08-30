// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine ());
int number2 = int.Parse(Console.ReadLine ());
if(number1 > number2)
{
    Console.WriteLine ($"Наибольшее из двух чисел: {number1}");
}
else
{
    Console.WriteLine ($"Наибольшее из двух чисел: {number2}");
}
