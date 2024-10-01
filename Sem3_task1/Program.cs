int[] array = { 1, 3, 4, 19, 3 };
Console.WriteLine("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

if (isExistNum == true)
{
    Console.WriteLine("Yes");
}
else
{ Console.WriteLine("No"); }

string result = isExistNum ? "Yes" : "No"; //Исполнение кода с помощью тернарного оператора можно уопростить до Console.WriteLine(isExistNum ? "Yes" : "No") - будет вывод в одну строку!
Console.WriteLine(result);