//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine ());
if(number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} четное.");
}
else
{
    Console.WriteLine($"Число {number1} нечетное.");
}