// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее.

System.Console.WriteLine("Введите первое число:");
int value1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 > value2)
{
    System.Console.WriteLine($"max {value1} , min {value2}");
}
if (value2 > value1)
{
    System.Console.WriteLine($"max {value2} , min {value1}");
}
