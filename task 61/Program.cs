﻿// ЗАДАЧА 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void RoadToNumber(int number)
{
if (number == 1)
{
System.Console.Write("1 ");
return;
}
RoadToNumber(number - 1);
System.Console.Write($"{number} ");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number);