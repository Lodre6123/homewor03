/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Напишите число N: ");
double N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов: ");

if (N < 0) N = -N;
else if (N == 0) Console.WriteLine("0 ");
for (double i = 1; i <= N; i++)
{
    double res = Math.Pow(i, 3);
    Console.Write($"{res} ");
}