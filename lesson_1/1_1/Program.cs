int num1 = 0;
int num2 = 0;

Console.Write("Write a number1 n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number2 n2 = ");
num2 = int.Parse(Console.ReadLine()!);

if (num2 * num2 == num1)
{
    Console.WriteLine("yes");
}
else
{
     Console.WriteLine("no");
}

