/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int userNumberA = new int();
int userNumberB = new int();
Console.Write("Введите число 1: ");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
userNumberB = Convert.ToInt32(Console.ReadLine());
if (userNumberA > userNumberB)
{
    Console.WriteLine("большее число: " + userNumberA);
    Console.WriteLine("меньшее число: " + userNumberB);
}
else if (userNumberA < userNumberB)
{
    Console.WriteLine("большее число: " + userNumberB);
    Console.WriteLine("меньшее число: " + userNumberA);
}
else
{
    Console.WriteLine("числа равны");
}