//  Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.

System.Console.WriteLine("Введите  число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = 1;

while (N1<N)
{
   if (N1 % 2 == 0)
{
    System.Console.Write($"{N1}");}
     N1=N1+1;
}

