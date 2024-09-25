
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;

while (i <= num)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
