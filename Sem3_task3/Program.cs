
int[] array = new int[6];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10, 11);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
if (array.Length % 2 == 0)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int sum = array[i] * array[array.Length - i - 1];
        Console.Write($"{sum} ");
    }
}
else
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int sum = array[i] * array[array.Length - i - 1];
        Console.Write($"{sum} ");
    }
    Console.WriteLine($"(Элемент {array[array.Length / 2 ]} не имеет пары)");
}