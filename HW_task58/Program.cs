// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void FillArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 11);
    }
  }
}

void PrintArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine("Введите число строк 1-ой матрицы m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-ой матрицы равное числу строк 2-ой матрицы n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-ой матрицы y:");
int y = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int[m,n];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
int [,] matrix2 = new int[n,y];
FillArray(matrix2);
PrintArray(matrix2);

int[,] resultMatrix = new int[m,y];

MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);