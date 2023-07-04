// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Multiplication(int num)
{
int multiplication = 1;
for (int i = 1; i <= num; i++)
{
multiplication = multiplication  * i;
}
return multiplication;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Multiplication(number)}");