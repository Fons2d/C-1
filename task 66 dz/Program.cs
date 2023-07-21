// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturals(int m, int n)
{
    if (m == n)
    {
         return m;
    }
    return m+SumNaturals(m+1, n);
}

System.Console.Write($"Введите число 1:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите число 2 (больше числа 1):  ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > num1) 
{
System.Console.WriteLine($"Сумма всех натуральных чисел от {num1} до {num2} = {SumNaturals(num1, num2)}");
}
else System.Console.WriteLine("Ошибка ввода. Введите другие числа.");