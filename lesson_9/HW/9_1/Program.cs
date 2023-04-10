// Задайте значения M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

static int SumNums(int M, int N)
{
   if(M==N) return M;
   else if(M==0) return (N*(N+1))/2;
   else if(N==0) return (M*(M+1))/2;
   else if(M>N) return N+SumNums(M,N+1);
   else return N+SumNums(M,N-1);
}

Console.WriteLine($"Сумма от {M} до {N} равна {SumNums(M,N)}");