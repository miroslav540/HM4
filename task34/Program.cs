static void FindEvens(string[] args)   
{
    int evens;
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        int A = (new Random()).Next(100,999); 
        result[i] = A;
        Console.Write(result[i] + " ");
    }
    evens = 0;
    for(int i = 0; i < size; i++)
    {
        if(result[i] % 2 == 0)
        {
            evens++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных: {0}\n", evens);
}

FindEvens(args);