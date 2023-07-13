// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int a = 5;
int b = 6;
int[,] array = new int[a, b];

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] col)
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

double summa = 0;
int column = 1;

for (int j = 0; j < b; j++)
{
    for (int i = 0; i < a; i++)
    {
        summa += array[i, j];           
    }
    double result = summa / a;
    Console.WriteLine($"Срднее арифмитечское столбца {column} равна: {result}");
    column++;
    summa = 0;
}