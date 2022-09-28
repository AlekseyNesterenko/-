// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateArray()
{
    Random random = new Random();
    int h = random.Next(2, 5);
    int w = random.Next(2, 5);
    int l = random.Next(2, 5);
    int[,,] matrix = new int[h, w, l];

    int[] randomNumbers = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = random.Next(10, 100);
        for (int index = 0; index < i; index++)
        {
            int n = randomNumbers[index];
            if (n == randomNumbers[i])
            {
                randomNumbers[i] = random.Next(10, 100);
                index = 0;
            }
        }
    }
    int count = 0;
    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            for (int k = 0; k < l; k++)
            {
                if (randomNumbers.Length > count)
                {
                    matrix[i, j, k] = randomNumbers[count++];
                }

            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент массива с индексом [{i},{j},{k}] равен {matrix[i, j, k]}  ");
            }
        }

    }
}



int[,,] array = CreateArray();
Console.WriteLine($"Трехмерный массив array[{array.GetLength(0)}, {array.GetLength(1)}, {array.GetLength(2)}]: ");
PrintMatrix(array);
