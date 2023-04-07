// Напишите программу, которая на вход принимает два числа
// A и В, и возводят число А в целую степень В с помощью рекурсии.

Console.Write("Введите число A =");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите числов В = ");
int B = int.Parse(Console.ReadLine()!);

double Div(int A, int B)
{
    if (B > 0) return Div(A,B-1)*A;
    if (B < 0) return Div(A,B+1)*1/A;
    else return 1;
}
Console.WriteLine(Div(A,B));