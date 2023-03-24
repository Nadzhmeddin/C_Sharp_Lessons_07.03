﻿// напишите цикл, который принимает на вход два числа (A и В)
// и возводит число А в натуральную степень В

double PowNum(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for(int i = 1; i <= b_abs; i++)
    {
        if (b>0)
            n_pow *=a;
        else 
            n_pow /=a;
    }
    return n_pow;
}

Console.Write("Введите число А = ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В = ");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNum(num_1, num_2));