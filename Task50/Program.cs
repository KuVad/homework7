// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Задайте нужный элемент: ");
int element = int.Parse(Console.ReadLine());
int flag = 0;
int count = 1;

FillArray(array);
PrintArray(array);

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (element == array [i, j])
        {
            Console.WriteLine($"Позиция {count} найденного элемента в массиве: строка - {i+1}, столбец {j+1}");
            count++;
            flag = 1;
        }
    }
}
if (flag == 0)
{
    Console.WriteLine("Такого элемента в массиве нет");
}