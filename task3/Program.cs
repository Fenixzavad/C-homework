// Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

System.Console.WriteLine("Введите  число:");
int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = value1 % 2;
if (value2 == 0)
{
    System.Console.WriteLine($" Число четное ");
}
else {System.Console.WriteLine($" Число  нечетное ");}
