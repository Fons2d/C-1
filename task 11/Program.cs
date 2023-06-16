// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int SecondDigitDelete(int num)
// {
// int digit1 = num / 100;
// int digit3 = num % 10;
// int result = digit1 * 10 + digit3;
// return result;
// }

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine($"Ваше случайное число: {number}");
// System.Console.WriteLine(SecondDigitDelete(number));

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Ваше случайное число: {number}");
int digit1 = number / 100;
int digit2 = number % 10;
int result = digit1*10+digit2;
System.Console.WriteLine($"Число без второй цифры = {result}");