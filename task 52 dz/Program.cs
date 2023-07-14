// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int row = 3;
int column = 3;
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

System.Console.Write("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
if (rowNumber <= 3 && columnNumber <= 3)
{
    System.Console.WriteLine(matrix[rowNumber-1, columnNumber-1]);
}
else
{
    System.Console.Write("Элемента c такими координатами не существует");
}