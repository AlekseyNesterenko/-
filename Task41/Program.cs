// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
          count++;
        }
    }
    return count;
}

try
{
Console.Write("Введите целые числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = CountPositiveNumber(array);
Console.WriteLine($"Кол-во элементов больше 0 = {count}");
}
catch(Exception)
{
    Console.WriteLine("Неверный формат!");
}
