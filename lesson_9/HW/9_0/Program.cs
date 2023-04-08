// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
EvenNum(M,N);
Console.WriteLine();


void  EvenNum(int a, int b)
{
    if(a-1 == b)
    {
        return;
    }
    EvenNum ((a,b-1)%2==0);
    Console.Write($"{b} ");
}

EvenNum(M,N);
Console.WriteLine();