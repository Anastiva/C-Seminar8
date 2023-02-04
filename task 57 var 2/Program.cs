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
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);

int[] CountArray = new int[10];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        int numbers = matrix[i,j];
        CountArray[numbers]= CountArray[numbers] + 1;
        }
    }
    for(int i = 0; i < CountArray.Length; i++)
    {
    if(CountArray[i]!=0)
        {
        Console.WriteLine($"Кол-во повторений для {i} = {CountArray[i]}");
        }
}
