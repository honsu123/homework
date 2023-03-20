Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void CreateArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void change(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
CreateArray(m, n);
change(m, n);