// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void RoadToNumber(int number, int firstpos)
{
if (number == firstpos)
{
System.Console.Write($"{number} ");
return;
}
RoadToNumber(number, firstpos + 1);
System.Console.Write($"{firstpos} ");
}

int firstpos = 1;
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=firstpos) RoadToNumber(number, firstpos);
else System.Console.WriteLine("Ошибка");

