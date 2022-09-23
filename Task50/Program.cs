// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    var random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(-100, 101);
        }
    }
    return array;
}

void FindArrayElement(int[,] array, int m, int n)
{
    if (m > array.GetLength(0) | n > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
        return;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if( m == array.GetLength(0) && n == array.GetLength(1))
                {
                Console.WriteLine($"Элемент с иденксом [{m},{n}] равен {array[i, j]}");
                }
            }
            break;
        }
    }
}

int rows = new Random().Next(2, 11);
int columns = new Random().Next(2, 11);
int[,] Array = CreateArray(rows, columns);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{Array[i, j]} ");
    }
    Console.WriteLine();
}

int m = 0; // строка
int n = 0; // столбец

Console.Write("Введите индекс (m): ");
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

Console.Write("Введите индекс (n): ");
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

FindArrayElement(Array, m, n);

