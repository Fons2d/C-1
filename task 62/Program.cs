// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int M = 5;
int N = 10;

void NaturalNumbers(int M, int N)
{ 
    if (N == M) 
    { 
        System.Console.WriteLine($"{N}"); 
        return; 
        } 
        NaturalNumbers(M, N - 1); 
        System.Console.WriteLine($"{N}");
        }
        NaturalNumbers(M, N);