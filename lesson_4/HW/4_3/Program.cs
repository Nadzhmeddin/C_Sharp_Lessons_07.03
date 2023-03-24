﻿// Напишите программу, которая задаёт массив из 8 элементов
// случайными числами и выдаёт их на экран. Оформите заполнение массива
// и вывод в виде функции (пригодится в следующих задачах)

void Print(int[] arr)
{
    int size = arr.Length;

    for(int i = 0; i < arr.Length; i++)
        Console.Write($" {arr[i]}");
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr  = new int [size];

    for(int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);