// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillArray(int[,,] array3)
{
  int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(5, 50);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(5, 50);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < array3.GetLength(0); m++)
  {
    for (int n = 0; n < array3.GetLength(1); n++)
    {
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[m, n, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray (int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(1); i++)
  {
    for (int j = 0; j < array3.GetLength(0); j++)
    {
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Console.Write( $"m({i}) n({j}) z({k})={array3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z:");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3 = new int[m, n, z];
FillArray(array3);
PrintArray(array3);
