﻿// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

int[,] WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int k = 0;
    int p = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_matr = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (m_indexes[0] != i && m_indexes[1] != j)
            {
                new_matr[k, p] = arr[i, j];
                p += 1;
            }
        }
        p = 0;        
        if (m_indexes[0] != i) k += 1;        
    }
    return new_matr;
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] new_mass = MinEl(mass);
int[,] res_mass = WithoutRowColumn(mass, new_mass);
Print(res_mass);

