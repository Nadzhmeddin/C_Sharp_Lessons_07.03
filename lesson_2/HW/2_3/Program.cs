﻿// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

void ThirdNum (int num)
{
    Console.Write($"{num}    ");
    if (num < 100)
    {
        Console.WriteLine ("Данное число не трёхзначное");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine( num % 10);
}

int val = int.Parse(Console.ReadLine()!);
ThirdNum(val);