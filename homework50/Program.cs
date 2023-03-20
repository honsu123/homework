Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int tmp = 0;

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            tmp++;
        }
    }
}
if (tmp >= 1)
    Console.WriteLine($"число {num} есть в данном массиве");
else Console.WriteLine($"числа {num} нет в массиве");
