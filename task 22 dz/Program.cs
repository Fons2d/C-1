// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int partnum1 = 0;
// int partnum2 = 0;
// if (num > 9999 && num < 100000)
// {
// partnum1 = num / 10000;
// int firstpart = num / 1000 % 10;
// partnum1 = firstpart + partnum1;
// partnum2 = num % 100;
// int secondpart = partnum2 / 10;
// partnum2 = partnum2 % 10;
// partnum2 = secondpart + partnum2;
// }
// else
// {
//     System.Console.Write("Вы ввели непятизначное число");

// }
// if (partnum1 == partnum2)
// {
//     System.Console.Write($"Число {num} является палиндромом");
// }
// else
// {
//    Console.WriteLine($"Число {num} не является палиндромом");
// }


Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"число {number} является палиндром");
    }
    else
    {
        Console.WriteLine($"число {number} не является палиндром");
    }
}
else
{
    Console.WriteLine($"Число {number} не является пятизначным");
}


