static void OddNumbersSum(string[] args)   
{
    int odd;
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        int A = (new Random()).Next(1,100); 
        result[i] = A;
        Console.Write(result[i] + " ");
    }
    odd = 0;
    for(int i = 0; i < size; i++)
    {
        if(i % 2 == 0) //не знаю почему, но код корректно работает только так, хотя я думал надо != 0, может просто уже устал
        {
            odd+=result[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма нечетных позиций: {0}\n", odd);
}

OddNumbersSum(args);
