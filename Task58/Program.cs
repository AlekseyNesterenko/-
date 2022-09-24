//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrix ()
{
	int random = new Random();
	int m = random.Next(1,5);
	int n = random.Next(1,5);
	int[,] matrix = new int[m, n];
	
	for(int i = 0; i < m; i++)
		{
			for(int j = 0; j < n; i++)
			{
				matrix[i, j] = random.Next(1, 11);
			}
		}

	return matrix;
}

void PrintMatrix (int[,] array)
{
	for(int i = 0; i < matrix.GetLength(0); i++)
		{
			for(int j = 0; j < matrix.GetLength(1); i++)
			{
				Console.Write($"{array[i, j]}  ");
			}
			Console.WriteLine();
		}
}			

int[,] MultiplyMatrices (int[,] matrixA, int[,] matrixB)
{
	int[,] result = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
	
	if(matrixA.GetLength(1) != matrixB.GetLength(0))
		{
			Console.WriteLine("Выполнить умножение невозможно!");	
		}
	else
		{
			for(int i = 0; i < matrixB.GetLength(0); i++)
				{
					for(int j = 0; j < matrixB.GetLength(0); i++)
						{
							int sumEl = 0;
							for( int k = 0; k < matrixA.GetLength(0); k++)
								{
									sumEl += matrixA[,] *matrixB[,];    // доделать
								}
							result[,] = sumEl;						
						}
				}
		{
	return result;
}


Console.WriteLine("Матрица А: ");
int[,] matrixA = CreateMatrix();
PrintMatrix(matrixA);
Console.WriteLine();

Console.WriteLine("Матрица Б: ");
int[,] matrixB = CreateMatrix();
PrintMatrix(matrixB);
Console.WriteLine();

Console.WriteLine("А х Б: ");
int[,] multResult = MultiplyMatrices(matrixA, matrixB);
PrintMatrix(multResult);
