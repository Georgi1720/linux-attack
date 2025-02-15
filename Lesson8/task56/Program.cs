﻿int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

List<int> SummList(int[,] array)
{
    var summList = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        summList.Add(summ);
        Console.Write(summList[i]+", ");
    }
    return summList;
}

void PrintMinimumString(List<int> minString)
{
    for(int i = 0; i < minString.Count; i++)
    {
        if(minString[i] == minString.Min())
        Console.WriteLine($"Строка {i+1} содержит наименьшую сумму массива  " );
    }
}

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
var summList = SummList(array);
Console.WriteLine();
PrintMinimumString(summList);
