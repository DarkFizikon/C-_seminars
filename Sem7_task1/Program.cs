void OutNumbers(int n)
{
    if (n == 0) return;
    OutNumbers(n - 1);
    Console.Write($"{n} ");
}

Console.Write("Entry natural num: ");
int num = Convert.ToInt32(Console.ReadLine());

OutNumbers(num);