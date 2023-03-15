
void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
{
Console.WriteLine("there is no third digit");
return;
}

while (num > 999) num /= 10;
Console.WriteLine(num % 10);
}

int val = int.Parse(Console.ReadLine()!);
ThirdNum(val);
