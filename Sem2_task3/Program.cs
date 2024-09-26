// using Internal;

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int ostatok = num1 % num2;
if (ostatok == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
        Console.WriteLine($"Первое число не кратно второму, остаток = {ostatok}");
}