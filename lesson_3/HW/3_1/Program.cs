﻿// напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.


void Number(int num)
{
    int num_first_second = num / 1000;
    int num_fifth = num %10;
    int num_four = num / 10 % 10;


    if (num_first_second == num_fifth*10 + num_four )
        Console.WriteLine($"Да, {num}  это число полиндром");
    else
        Console.WriteLine($"Нет, {num} это число не полиндром");

}

Console.WriteLine(" Введите пятизначное число");
int val = int.Parse(Console.ReadLine()!);
Number(val);
