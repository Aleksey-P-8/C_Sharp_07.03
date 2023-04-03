// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

Console.Write("Кол-во элементов в строке:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во элементов в столбце:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b = int.Parse(Console.ReadLine()!);

int[,] MakeArray(int x, int y, int m, int n)
{
    int[,] array = new int[x, y];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = new Random().Next(m, n + 1);
        }

    }

    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = MakeArray(x, y, a, b);
PrintArray(array);
////////////////////////////////////////////

Console.Write("Введите число для поиска: ");
int n = int.Parse(Console.ReadLine()!);

string FindNum(int[,] arr, int x)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (arr[i,j]==x) return $"Искомое чило {x}. Его координаты [{i+1},{j+1}].";
        }
    }
return $"Искомое число {x} не найдено.";

}

Console.Write(FindNum(array,n));
