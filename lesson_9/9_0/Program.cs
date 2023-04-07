// Задача 0: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

// https://www.youtube.com/watch?v=F4HNO4rCQ2c&ab_channel=KhanAcademyRussian
//https://youtu.be/rh1mP02NFoM?t=229
// https://skillbox.ru/media/code/rekursiya-vokrug-nas/


Console.Write("Введите значение N = ");
int Num = int.Parse(Console.ReadLine()!);

void PrintNums(int n)
{
    if (n ==0) return;
    PrintNums(n - 1);
    Console.Write($"{n} ");
}

Console.Write("Result: ");
PrintNums(Num);