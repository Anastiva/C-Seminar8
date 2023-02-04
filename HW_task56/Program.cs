// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
if(m == n)
{
    Console.Write("Неверно. Введен квадратный массив");
}
else
{
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);
}

int SumRowElements(int[,] matrix, int i)
{
  int sumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRow += matrix[i,j];
  }
  return sumRow;
}

int minSum = 0;
int sumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSum = SumRowElements(matrix, i);
  if (sumRow > tempSum)
  {
    sumRow = tempSum;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой элементов ({sumRow}) ");
