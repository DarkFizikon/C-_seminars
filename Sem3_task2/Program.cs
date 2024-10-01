int[] array = new int [10];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(-10, 11); 
            Console.Write($"{array[i]} ");
    }
   Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
        Console.Write($"{array[i]} ");
    }
