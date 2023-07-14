// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillMatrixWithRandom(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} \t");
}
System.Console.WriteLine();
}
}

double[] arithmeticmean(int[,] matrix)
{
double[] arithmetic = new double[matrix.GetLength(1)];
for (int j = 0; j < matrix.GetLength(1); j++)
{
double sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
sum += matrix[i, j];
}
arithmetic[j] = Math.Round(sum / matrix.GetLength(0), 1);
}
return arithmetic;
}


System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine($"Среднее арифмитическое каждого столбца: [{string.Join("; ", arithmeticmean(matrix))}]");