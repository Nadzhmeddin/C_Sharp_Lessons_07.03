// Задайте значения M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

int SumNums(int a, int b)
{
   if(a==b) return a;
   else return a+ SumNums(a+1,b);
}
Console.Write($"Сумма чисел {M} и {N} равна = {SumNums(M,N)}");

