// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координату X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());

double num1 = (Math.Pow(x2-x1, 2));
double num2 = (Math.Pow(y2-y1, 2));
double num3 = (Math.Pow(Z2-Z1, 2));
double result = num3 + num2+ num1;
System.Console.Write(Math.Round(Math.Sqrt(result), 3));
