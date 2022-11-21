/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int userNumberA = new int();
int userNumberB = new int();
int userNumberC = new int();
Console.Write("Введите число 1: ");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
userNumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
userNumberC = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;
if (userNumberB > max)
{
    max = userNumberB;
}
if (userNumberC > max)
{
    max = userNumberC;
}
Console.WriteLine("Максимальное число: " + max);