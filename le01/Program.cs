//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.Write("введите количество строк :");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов :");
int columnsnumber = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsnumber];
ArrayRandomNumbers(numbers);
PrintArray(numbers);

void ArrayRandomNumbers(double[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[c, j] = Convert.ToDouble(new Random().Next(-10, 1000)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int a= 0; a < array.GetLength(1); a++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[a, j] + "; ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}