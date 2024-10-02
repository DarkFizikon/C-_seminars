Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min rnd num: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max rnd num: ");
int max = Convert.ToInt32(Console.ReadLine());

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

int CountPrimeNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (IsPrime(arr[i]))
        {
            count++;
        }
    }
    return count;
}

bool IsPrime(int num)
{
    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

int[] array = CreateArrayRndInt(size, min, max);
ShowArray(array);
int countPrime = CountPrimeNumbers(array);
Console.WriteLine($"=> {countPrime}");