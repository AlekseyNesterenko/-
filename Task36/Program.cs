// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

//метод считает сумму элементов на нечетных позициях
int GetSumNumbersOddPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Полученный массив: ");
int[] array = FillArray(11, -10, 11);
PrintArray(array);

Console.WriteLine();
Console.Write("Сумма чисел на нечетных позициях: ");
int sum = GetSumNumbersOddPosition(array);
Console.Write(sum);