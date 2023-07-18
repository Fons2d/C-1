// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void FillMatrix3D(int[,,] matrix3D)
{
    Random rnd = new Random();
    int temp;
    int size = 180; 
    List<int> library = new List<int>(size);
    for (int i = size / 2 - 1; i >= 0; i--)  library.Add(-i - 10); 
    for (int i = 0; i < size / 2; i++) library.Add(i + 10); 

    for (int i = library.Count - 1; i >= 1; i--) 
    {
        int j = rnd.Next(i + 1);
        temp = library[j];
        library[j] = library[i];
        library[i] = temp;
    }

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                temp = rnd.Next(library.Count);
                matrix3D[i, j, k] = library[temp];
                library.RemoveAt(temp);
            }
        }
    }
}

void PrintMatrix3D(int[,,] matrix3D)
{
    System.Console.WriteLine("\nВывод методом прямого последовательного перебора\n");
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                System.Console.Write($"{matrix3D[i, j, k]} \t({i},{j},{k})    |\t");
            }
            System.Console.WriteLine();
        }
    }
    System.Console.WriteLine("\nВывод как указано в примере к задаче\n");
    for (int x = 0; x < matrix3D.GetLength(2); x++)
    {
        for (int z = 0; z < matrix3D.GetLength(0); z++)
        {
            for (int y = 0; y < matrix3D.GetLength(1); y++)
            {
                System.Console.Write($"{matrix3D[z, y, x]} \t({z},{y},{x})    |\t");
            }
            System.Console.WriteLine();
        }
    }
}

System.Console.WriteLine("Задайте параметры 3-мерной матрицы для заполнения уникальными целыми 2-значными числами (максимум 6x6x5):");
System.Console.Write("размерность X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("размерность Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("размерность Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int[x, y, z];

if (x + y + z < 18)
{
    FillMatrix3D(matrix3D);
    PrintMatrix3D(matrix3D);
}
else System.Console.WriteLine("Заполнить матрицу такого размера уникальными целыми 2-значными числами невозможно");