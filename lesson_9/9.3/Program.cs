// 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

double StepNum (int a,int b)
{
if(b>0) return StepNum (a,b-1)*a;
if(b<0) return StepNum (a,b+1)*1/a;
else return 1;
}
Console.WriteLine(StepNum (3,2));
Console.WriteLine(StepNum (3,-2));
Console.WriteLine(StepNum (3,0));
