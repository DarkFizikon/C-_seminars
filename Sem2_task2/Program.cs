Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num / 100 > 0) && (num / 100 <= 9))
{
    int a = (num / 10) % 10;
    int b = num % 10;
    int i = 1;
    int result = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }
    Console.WriteLine($"Результат = {result}");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}