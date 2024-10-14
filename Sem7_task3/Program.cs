void PrintConsanants(string text, int i = 0)
{
    if (i == text.Length)
    {
        return;
    }
    CheckConsanats(text, i);
    PrintConsanants(text, i + 1);
}

void CheckConsanats(string text, int i)
{
    string vowels = "aeiouy";
    if (char.IsAsciiLetter(text[i]) && !vowels.Contains(text[i]))
    {
        Console.Write($"{text[i]}");
    }
}

Console.Write("Entry string: ");
string str = Console.ReadLine();
PrintConsanants(str);