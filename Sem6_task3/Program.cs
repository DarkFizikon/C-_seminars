int CountVowels(string str)
{
    string vowels = "aeiuyo";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == str[i])
            {
                count++;
            }
        }
    }
    return count;
}


Console.Write("Input string: ");
string str = Console.ReadLine();
Console.WriteLine($"In word {CountVowels(str)} vowel's");