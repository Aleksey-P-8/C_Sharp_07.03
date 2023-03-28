// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

Console.Write("n=");
int n = int.Parse(Console.ReadLine()!);
/*
void Fibonacci(int n){
int a=0;
int b=1;
Console.Write($"{a} {b} ");

for (int i=2;i<n;i++){
Console.Write($"{a+b} ");
(a,b)=(b,a+b);

}
}*/

Fibonacci(n);

void Fibonacci(int n)
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);

    }
}