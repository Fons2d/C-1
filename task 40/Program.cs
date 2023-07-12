// Задача 39 переворачивает массив, первое на последнее и т.д

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 100);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(Length);
System.Console.WriteLine(string.Join("; ", array));

int[] ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[Length - 1 - i] = temp;
    }
    return arr;
}

System.Console.WriteLine(string.Join("; ", ReverseArray(array)));