char[] StringToCharArray(string s)
{
    char[] arr = new char[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        arr[i] = s[i];
    }
    return arr;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Input string: ");
string str = Console.ReadLine();
char[] result = StringToCharArray(str);
PrintArray(result);