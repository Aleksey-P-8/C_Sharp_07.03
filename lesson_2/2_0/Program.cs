int TakeNum(int num)
{
Console.WriteLine(num);
return num % 10;
}
// 123 / 10 -> 12
// 123 % 10 -> 3

int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);
