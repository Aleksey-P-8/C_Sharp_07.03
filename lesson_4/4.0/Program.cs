// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNum(int num)
{
int sum_all = 0;

for(int i = 1; i <= num; i++)
sum_all += i;

return sum_all;
}

int val = int.Parse(Console.ReadLine()!);
int result = SumNum(val);
Console.WriteLine(result);
