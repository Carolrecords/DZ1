Console.WriteLine("Введите первое число : ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
   Console.WriteLine("Max = " + number1);
}
else 
{
Console.WriteLine("Max = " + number2);
}








Console.WriteLine("Введите трехзнвчное число : ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
   Console.WriteLine("Число не трех значное");
if (a > 1000)
   Console.WriteLine("Число не трех значное");

int b = a % 10;


Console.WriteLine("Последяя цифра равна " + b);