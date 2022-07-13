static void DifOfMinAndMax(string[] args)
{
    double dif = 0;
    double sum = 0;
    int max;
    int min;
    Console.WriteLine("Enter how many numbers u want");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    max = arr[0];
    min = arr[0];
    for (int i = 0; i < size; i++)
    {
        arr[i] = (new Random()).Next(1,100);
        if(arr[i] < min) // я не знаю почему, но так работает, по другому не работает, может за решение и ошибка, но ответ всегда верный)
        {
            max=arr[i];
        }
        if (arr[i] > max)// если меня переменные как надо, минимум всегда равен = 0, я не понял как ее решить по другому
        {
            min=arr[i];
        }
        sum += arr[i];
         Console.WriteLine(arr[i] + " ");
    } 
    dif = min - max;
    Console.WriteLine("sum = {0}, difference = {1}, max = {2}, min = {3}", sum, dif, min, max);// изобрел свой первый кастыль)
}

DifOfMinAndMax(args);