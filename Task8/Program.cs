// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine ());
int number = 1;
Console.Write($"Четные числа от 1 до {number1}: ");
while(number<number1 + 1) {
    if(number % 2 == 0) 
    {
    Console.Write($"{number} ");
    }
    number ++;
}
