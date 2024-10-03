
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = rnd.Next(min, max);
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int SumMainDiag(int[,] matrix)
{ int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            if (i == j)
            {
                sum = sum + matrix[i,j];
            }
        }
    }
    return sum;
}

Console.Write("Input array rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min rnd num: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max rnd num: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] mat = CreateMatrixRndInt(rows, columns, min, max);
ShowMatrix(mat);
Console.WriteLine();
int result = SumMainDiag(mat);
Console.WriteLine($"=> {result}");