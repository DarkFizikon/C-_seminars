int[] CreateArr(int sizearray, int lower, int upper)
{
    int[] array = new int[sizearray];

    Random rnd = new Random();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(lower, upper);
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
    return array;
}

void PrintArray(int[] newarr, int i = 0)
{
    if (i >= newarr.Length)
    {
        return;
    }
    PrintArray(newarr, i + 1);
    Console.Write($"{newarr[i]} ");
}


Console.Write("Entry size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Entry lower random limit: ");
int low = Convert.ToInt32(Console.ReadLine());
Console.Write("Entry upper random limit: ");
int up = Convert.ToInt32(Console.ReadLine());
int[] createarr = CreateArr(size, low, up);
PrintArray(createarr);