﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int check(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = check("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
Console.Write($"Введенное число '{number}' ");
int digit2 = number / 10 % 10;
Console.WriteLine($"{digit2}");
