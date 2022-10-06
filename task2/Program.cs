//  Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число:");
int value1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int value2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = value1;
if (value2 > max) 
{
    max = value2;
}
if (value3 > max) 
{
    max = value3;
}
else {System.Console.WriteLine($" {max} ");}
