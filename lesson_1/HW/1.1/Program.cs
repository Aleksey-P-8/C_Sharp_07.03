int num1 = 0;
int num2 = 0;

Console.Write("Write a number1 n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write a number2 n2 = ");
num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.Write(num1);
    Console.Write(" -> max");
    
}
else if (num1 < num2)
{
     Console.Write(num2);
     Console.Write(" -> max");
   
}
else 
{
    Console.Write(num1);
    Console.Write(" -> равно");
}
