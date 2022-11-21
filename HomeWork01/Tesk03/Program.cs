/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 
два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int userNumber = new int();
Console.Write("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0) 
{
    Console.WriteLine("Ваше число является четным");
}
else
{
    Console.WriteLine("Ваше число не является четным");
}