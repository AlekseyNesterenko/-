// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillArraySpiral()
{
  int[,] array = new int[4,4];
  int i = 0;
  int j = 0;
  int count = 0;
   while (count < array.GetLength(0) * array.GetLength(1))
   {
     if(j<array.GetLength(1)) 
     {
       array[i, j] = count++;
       j++;
     }
     if (i<array.GetLength(0))
        {
       array[i, j] = count++;
       i++;
     }
         if(j<array.GetLength(1)) 
     {
       array[i, j] = count++;
       j--;
     }
     if (i<array.GetLength(0))
        {
       array[i, j] = count++;
       i--;
     }
     
   }
}

