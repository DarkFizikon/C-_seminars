Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
int numCopy = num;
int count = 0;

while (numCopy!=0)
{
    numCopy/=10;
    count++;
}

int [] array = new int [count];
int index = array.Length - 1;
while (num !=0)
{
    array[index] = num%10;
    num /=10; //num = num / 10;
    index--;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}