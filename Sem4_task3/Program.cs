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

int ArrayToNumber(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res = res * 10 + arr[i];
    }
    return res;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 1 || size > 8)
{
    Console.WriteLine("Input is wrong");
    return;
}
Console.Write("Input min rnd num: ");
int min = Convert.ToInt32(Console.ReadLine());
if (min < 0)
{
    Console.WriteLine("Input is wrong");
    return;
}
Console.Write("Input max rnd num: ");
int max = Convert.ToInt32(Console.ReadLine());
if (max > 9)
{
    Console.WriteLine("Input is wrong");
    return;
}


int[] array = CreateArrayRndInt(size, min, max);
ShowArray(array);
int result = ArrayToNumber(array);
Console.WriteLine($"=>{result}");