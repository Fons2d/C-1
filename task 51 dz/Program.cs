// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillMatrixWithRandom(double[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = Math.Round(rnd.Next(-100, 101)*0.1, 1);
}
}
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} ");
}
System.Console.WriteLine();
}
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);