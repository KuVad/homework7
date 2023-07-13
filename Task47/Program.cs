// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задайте количество столбцов: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество строк: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[n, m];

void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(-10, 10);
        }
    }
}

void PrintArray(double[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for(int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]}   ");
        }
        Console.WriteLine("");
    }
}

FillArray(array);
PrintArray(array);