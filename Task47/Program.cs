// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    var random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 200 - 100, 1);  // рандомные вещественные числа от -100 до 100 с округением до 1 знака.
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
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

double[,] resultArray = CreateArray(m, n);
PrintArray(resultArray);



