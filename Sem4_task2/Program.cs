int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}
void ShowArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]} ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.WriteLine("]");
}

int CountNumsLastADevB(int[] arr, int aLast, int bDev)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 10 == aLast && arr[i] % bDev == 0)
        {
            count++;
        }
    return count;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min rnd num: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max rnd num: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input last num: ");
int aLast = Convert.ToInt32(Console.ReadLine());
Console.Write("Input devine num: ");
int bDev = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(size, min, max);
ShowArray(array);
int result = CountNumsLastADevB(array, aLast, bDev);
Console.WriteLine(result);