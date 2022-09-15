/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
*/

int[] FillArray( int size, int startValue, int endValue)
{
    var array = new int[size];

    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(startValue,endValue+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for( int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int[] MyltiplyPairs(int[] array)
{
    if(array.Length % 2 == 0)
    {
        int[] newArray = new int[array.Length/2];
        for(int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length-i-1];
        }
        return newArray;
    }

     else
    {
        int[] newArray = new int[array.Length/2+1];
        for(int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length-i-1];
        }
        newArray[newArray.Length-1] = array[array.Length/2];
        return newArray;
    }
}

Console.Write("Полученный массив: ");
int[] array = FillArray(9, 1, 11);
PrintArray(array);

Console.WriteLine();
Console.Write("Массив после умножения пар: ");
int[] newArray = MyltiplyPairs(array);
PrintArray(newArray);