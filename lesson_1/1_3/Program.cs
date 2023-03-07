Console.Write("N=");
int n = int.Parse(Console.ReadLine()!);

int count = -n;

while (count != n)
{
Console.WriteLine(count);
if (n < 0)
{
count--;
}
else
{
count++;
}

}

