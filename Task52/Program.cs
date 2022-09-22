// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateAndPrintArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[] GetAverageColumns (int[,] array, int m, int n)
{
    int[] average = new int[n];
    for(int k = 0; k<average.Length; k++)
    {
        int sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum += array[m,n];
        }
        average[k]= sum / m;
    }
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



int[] columnsAverageSum = GetAverageColumns(CreateAndPrintArray(m,n));

