// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N с помощью рекурсии.


Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

void EvenNums(int a, int b)
{
    if (a > b) return;
    if (a % 2 == 0 & a > 0) Console.Write($"{a} ");
    EvenNums(a + 1, b);
}

EvenNums(M,N);