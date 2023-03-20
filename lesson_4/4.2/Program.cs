// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int num = GetUserNumber();
int digits = MultiplyNumbers(num);
Console.WriteLine(digits);

int GetUserNumber()
{
int number = 0;
while(number == 0)
{
Console.Write("Please enter number: ");
number = int.Parse(Console.ReadLine()!);
}
return number;
}

int MultiplyNumbers(int n)
{
int multi = 1;
for (int i = 1; i <= n; i++)
{
multi = multi * i;
}
return multi;
}
