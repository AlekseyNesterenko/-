// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// метод генерирует массив
double[] FillArray( int size, int startValue, int endValue)
{
    double[] array = new double[size];
    var random = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (endValue - startValue) + startValue, 3);
    }
    return array;
}

// метод выводит массив в консоль
void PrintArray(double[] array)
{
    for( int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

//поиск минимального элемента массива
double GetMinNumber(double[] array)
{
    var min = array[0];
    for(int i = 0; i<array.Length; i++)
    if (array[i] < min) min = array[i];
    return min;
}

// поиск максимального элемента массива
double GetMaxNumber(double[] array)
{
    var max = array[0];
    for(int i = 0; i<array.Length; i++)
    if (array[i] > max) max = array[i];
    return max;
}

Console.Write("Полученный массив: ");
double[] array = FillArray(10, -10, 10);
PrintArray(array);

Console.WriteLine();
double max = GetMaxNumber(array);
double min = GetMinNumber(array);
Console.WriteLine($"Разница между максимальным числом '{max}' и минимальным '{min}' = {max-min}");
