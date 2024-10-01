
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
//Решение с семинара
// int[] array = { 2, 3, 1, 7, 5, 6, 3 };
// int[] arrayResult = new int[array.Length / 2];

// int left = 0;
// int right = array.Length - 1;

// while (left < right)
// {
// arrayResult[left] = array[left] * array[right];
// left++;
// right--;
// }

// for (int i = 0; i < arrayResult.Length; i++)
// {
// Console.Write(arrayResult[i] + " ");
// }