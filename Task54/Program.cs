// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrix()
{
    Random random = new Random();
    int m = random.Next(2, 5);
    int n = random.Next(2, 5);
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

int[,] SortInArrayRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                    int tmp = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
    return array;
}


int[,] array = CreateMatrix();

PrintMatrix(array);

Console.WriteLine();

int[,] sortedArray = SortInArrayRow(array);

PrintMatrix(sortedArray);

