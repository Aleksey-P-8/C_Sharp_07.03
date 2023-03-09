int num1 = 0;
int num2 = 0;
int num3 = 0;

Console.Write("Write a number1 n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number2 n2 = ");
num2 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number1 n3 = ");
num1 = int.Parse(Console.ReadLine()!);

if (num1 < num2)
{
    num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}

Console.Write($"Номер {num1} наибольшее");
