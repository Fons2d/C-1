// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Lastnumber = number % 2;
if (Lastnumber == 0)
{
System.Console.Write($"Число {number} является четным числом");
}
else
{
System.Console.Write($"Число {number} является нечетным числом");
}