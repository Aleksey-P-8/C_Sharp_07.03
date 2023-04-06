// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] arr_first, int[,] arr_second)
{
    int row_1 = arr_first.GetLength(0);
    int column_1 = arr_first.GetLength(1);
    
    int row_2 = arr_second.GetLength(0);
    int column_2 = arr_second.GetLength(1);


    int[,] pr_matrix = new int[row_1, column_1];

    if (column_1 != row_2) return pr_matrix;
    else if (column_1 == row_2)
        pr_matrix = new int[row_1, column_2];

    for (int i = 0; i < row_1; i++)
    {
        for (int j = 0; j < column_2; j++)
        {
            for (int p = 0; p < column_1; p++)

                pr_matrix[i, j] += arr_first[i, p] * arr_second[p, j];
        }
    }
    return pr_matrix;
}


Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row_1, column_1, 1, 10);
Print(arr_1);
int[,] arr_2 = MassNums(row_2, column_2, 1, 10);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);

