// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//метод, позволяющий получить кубы чисел от 1 до N.
int[] GetCubes(int num)   
{
    int[] array = new int[num];
    for (int i = 1; i <= num; i++)
    {
        array[i-1] = i*i*i;
    }
    return array;
}

Console.Write("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица кубов от 1 до {num} ");
int[] result = GetCubes(num);
for (int i= 0; i < result.Length; i++) 
{
    Console.WriteLine(result[i]);
}
