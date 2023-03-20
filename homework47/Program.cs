double[,] mass (int m, int n)
{
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.NextDouble() * 10;
        
        Console.Write(string.Format("{0:F1}", array[i,j]));
        Console.Write(" ");
    }
    Console.WriteLine();
}
return array;
}
mass(3, 4);