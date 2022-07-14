static void DifOfMinAndMax(string[] args)
{
    double dif;
    double sum = 0;
    int max = 0;
    int min = 100;
    Console.WriteLine("Enter how many numbers u want");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = (new Random()).Next(1,100);
        if (arr[i] >= max)
        {
            max = arr[i];
        }
        if (arr[i] <= min)
        {
            min = arr[i];
        }
        sum += arr[i];
        Console.WriteLine(arr[i] + " ");
    } 
    dif = max - min;
    Console.WriteLine("sum = {0}, difference = {1}, max = {2}, min = {3}", sum, dif, max, min);
}

DifOfMinAndMax(args);
