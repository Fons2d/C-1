// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double Distance2D(double Ax, double Ay, double Bx, double By)
// {
// double distance = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
// return Math.Round(distance, 2);
// }

// System.Console.Write("Введите координату Х точки А: ");
// double Ax = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Y точки А: ");
// double Ay = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Х точки B: ");
// double Bx = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Y точки B: ");
// double By = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Расстояние между точками A и B равно {Distance2D(Ax, Ay, Bx, By)}"

System.Console.Write("Введите координату X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
// Stopwatch = new Stopwatch();
// stopwatch.Start();
double num1 = (Math.Pow(x2-x1, 2));
double num2 = (Math.Pow(y2-y1, 2));
double result = num2+ num1;
System.Console.Write(Math.Round(Math.Sqrt(result), 3));
// stopwatch.Stop();
// Console.WriteLine(stopwatch.ElapsedMilliseconds);