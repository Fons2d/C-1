﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Lastnumber = number % 10;
System.Console.Write($"Последняя цифра числа: {Lastnumber}");
