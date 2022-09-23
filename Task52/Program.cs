// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

double[] GetAverageInColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average[k] = sum / array.GetLength(0);
        k++;
    }
    return average;
}

int m = 0; // количество строк
int n = 0; // количество столбцов

Console.Write("Введите количество строк (m): ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int resultM);
if (!parseMIsOk)
{
    Console.WriteLine("Неверный тип данных");
    return;
}
else
{
    m = resultM;
}

Console.Write("Введите количество столбцов (n): ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int resultN);
if (!parseNIsOk)
{
    Console.WriteLine("Неверный тип данных");
    return;
}
else
{
    n = resultN;
}

int[,] Array = CreateArray(m, n);
PrintArray(Array);
Console.WriteLine();

Console.WriteLine();
double[] columnsAverageSum = GetAverageInColumns(Array);
for (int i = 0; i < columnsAverageSum.Length; i++)
{
    Console.Write($"{columnsAverageSum[i]} ");
}
