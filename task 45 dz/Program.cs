// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество элементов в массиве: ");

int Elementscount = int.Parse(Console.ReadLine());
int[] arr = new int[Elementscount];
int count = 0;

for (int i = 0; i < arr.Length; i++)
    {
    System.Console.WriteLine($"Введите число под индексом {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
    }

System.Console.WriteLine("\nВывод массива: ");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 )
        count = count + 1;
    }
    System.Console.WriteLine($"\nПользователь ввел {count} чисел больше 0");
