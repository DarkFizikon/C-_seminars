int ResultAck(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ResultAck(m - 1, 1);
    }
    else
    {
        return ResultAck(m - 1, ResultAck(m, n - 1));
    }

}

void PrintResult(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Error! Invalid input!");
    }
    else
    {
        int res = ResultAck(m, n);
        Console.WriteLine($"Result of Ackerman function is {res}");
    }
}

Console.Write("Entry natural number m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Entry natural number n = ");
int n = Convert.ToInt32(Console.ReadLine());

PrintResult(m, n);
