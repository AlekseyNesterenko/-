// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix()
{
    Random random = new Random();
    int m = random.Next(4, 5);
    int n = random.Next(2, 3);
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(1, 11);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] FindMaxSumRow (int[,] array)
{
    int[] sumPows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumPows[i] = sum;
    }
    return sumPows;
}

void PrintMaxSumPow (int[] array)
{
    int min = array[0];
    int powNum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[i-1]) 
        {
            min = array[i];
            powNum = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма в ряду {powNum+1} и равна {min}");
}
int[,] array = CreateMatrix();

PrintMatrix(array);

Console.WriteLine();

int[] sum = FindMaxSumRow(array);
PrintMaxSumPow(sum);
