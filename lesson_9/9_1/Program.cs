// Задайте значения M и N. напишите программу, 
//которая рекурсивно выдает все натуральные числа в промежутке от M до N.

Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

void PrintNumbers (int a, int b)
{
    if(a -1 ==b)
    {
        return;
    }
    PrintNumbers(a,b-1);
    Console.Write($"{b} ");
}

PrintNumbers(M,N);