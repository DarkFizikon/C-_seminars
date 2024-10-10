int SumDigits(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDigits(n / 10);
}
Console.Write("Entry natural num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(num)); // 120