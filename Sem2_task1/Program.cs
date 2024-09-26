Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num/100 > 0) && (num/100 <= 9))
{
    int a = num%10;
    int b = num/100;
    int num2 = b*10 + a;
    Console.WriteLine($"Новое число = {num2}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}