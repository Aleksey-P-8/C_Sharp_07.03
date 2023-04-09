// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//input data
Console.Write("Enter the first number: ");
int N = int.Parse(Console.ReadLine()!);

//functions
void PrintNums(int n)
{
if (n == 0) return;
PrintNums(n - 1);
Console.Write($"{n} ");
}

//result
Console.Write("Result: ");
PrintNums(N);