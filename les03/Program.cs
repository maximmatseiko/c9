//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк :");
int numberlines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов :");
int numbercolumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[numberlines, numbercolumns];
ArrayRandomNumbers(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double arithmeticmean = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arithmeticmean = (arithmeticmean + numbers[i, j]);
    }
    arithmeticmean = arithmeticmean / numberlines;
    Console.WriteLine($"Среднее арифметическое :{arithmeticmean} ");
}
Console.WriteLine();
PrintArray(numbers);



void ArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[a, c] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int s = 0; s < array.GetLength(0); s++)
    {
        Console.Write("[ ");
        for (int d = 0; d < array.GetLength(1); d++)
        {
            Console.Write(array[s, d] + " ; ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
