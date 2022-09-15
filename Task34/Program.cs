// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// метод генерирует массив
int[] FillArray( int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = random.Next(startValue,endValue+1);
    }
    return array;
}

// метод выводит массив в консоль
void PrintArray(int[] array)
{
    for( int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

// Метод считает четные числа
int CountEvenNumbers(int[] array)
{
    int countNumbers = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            countNumbers++;
        }
    }
    return countNumbers;
}

Console.Write("Полученный массив: ");
int[] array = FillArray(10, 100, 1000);
PrintArray(array);

Console.WriteLine();
Console.Write("Количество четных чисел: ");
int evenNumbers = CountEvenNumbers(array);
Console.Write(evenNumbers);