// using Internal;

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num/100 > 0) && (num/100 <= 9))
{
    int a = num/100;
    int b = num%10;
    int sum = a + b;
    Console.WriteLine($"Сумма чисел = {sum}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}