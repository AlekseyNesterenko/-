// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

int[] InputArray()
{
    int[] array = new int[8];
    Console.WriteLine("Введите элементы массива: ");
    for (int i=0;i<array.Length; i++)
    {
        try
        {
            Console.Write($"Элемент массива с индексом [{i}]= ");
            array[i] = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            System.Console.WriteLine("Входное значение имеет неверный формат");
            i--;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив из 8 элементов: ");
    for( int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = InputArray();
Console.WriteLine();
PrintArray(array);