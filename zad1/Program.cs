// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string? Num = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
       Console.WriteLine($"Введенное число {number} палиндром"); 
    }           
    else Console.WriteLine($"Введенное число {number} не палиндром");
}
    if (Num!.Length == 5)
    {
        CheckingNumber(Num);
    }
    else Console.WriteLine($"Вы ввели не корректное число");