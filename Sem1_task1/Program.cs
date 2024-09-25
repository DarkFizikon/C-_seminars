
// using Internal;

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;

if (num > 0)
{
    while (i <= num)
    {
        Console.Write(i + " ");
        // Console.Write(" ");
        i++;
    }
}

else
{
    Console.Write("Ошибка ввода!");
}