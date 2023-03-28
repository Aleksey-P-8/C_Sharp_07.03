// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("a=");
int a = int.Parse(Console.ReadLine()!);
Console.Write("b=");
int b = int.Parse(Console.ReadLine()!);
Console.Write("c=");
int c = int.Parse(Console.ReadLine()!);

bool MyFunc(int a, int b, int c)
{
if (a < b + c && b < a + c && c < a + b)
{
return true;
} else return false;
}

Console.Write(MyFunc(a,b,c));
