// using Internal;

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int thirdnum = num % 10;
    if (thirdnum > 0)
    {
        Console.WriteLine($"Третья цифра чиса = {thirdnum}");
    }
    else
    {
        thirdnum = -thirdnum;
        Console.WriteLine($"Третья цифра чиса = {thirdnum}");
    }
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}