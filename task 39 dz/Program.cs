// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


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
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int max = 0;
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
   if (array[i] > max)
   {
   max = array[i];
   }
   else if (array [i] < min) 
    {
        min = array[i];
    }
}
System.Console.WriteLine($"максимальное значение = {max}, минимальное значение = {min}");
int difference = max - min;
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {difference}");