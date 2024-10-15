void OutputNumbers(int m, int n, int direction)
{
    if (direction == 1)
    {
        if (m > n)
        {
            return;
        }
        OutputNumbers(m, n - 1, 1);
    }
    if (direction == -1)
    {
        if (n > m)
        {
            return;
        }
        OutputNumbers(m, n + 1, -1);
    }
    if (m == n)
    {
        Console.Write(n);
    }
    else
    {
        Console.Write(", ");
        Console.Write(n);
    }
}

void PrintNumbers(int m, int n)
{
    if (m <= 0 || n <= 0)
    {
        Console.WriteLine("Error! Invalid input!");
    }
    else
    {
        Console.Write("Numbers in bertween: [");

        if (m <= n)
        {
            OutputNumbers(m, n, 1);
        }
        else
        {
            OutputNumbers(m, n, -1);

        }
        Console.Write("]");
    }
}

Console.Write("Entry natural number m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Entry natural number n = ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);

