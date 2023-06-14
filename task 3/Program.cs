// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите номер дня недели: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// if (numberA == 1)
// {
// System.Console.WriteLine("Понедельник");    
// }
// else if (numberA == 2)
// {
// System.Console.WriteLine("Вторник");    
// }
// else if (numberA == 3)
// {
// System.Console.WriteLine("среда");    
// }
// else if (numberA == 4)
// {
// System.Console.WriteLine("Четверг");    
// }
// else if (numberA == 5)
// {
// System.Console.WriteLine("Пятница");    
// }
// else if (numberA == 6)
// {
// System.Console.WriteLine("Суббота");    
// }
// else if (numberA == 7)
// {
// System.Console.WriteLine("Воскресенье");    
// }
// else
// {
// System.Console.WriteLine("Дня недели под таким номером не существует");       
// }

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
case 7:
Console.WriteLine("Воскресенье");
break;
default:
Console.WriteLine("Дня недели с такоим номером не существует");
break;
}