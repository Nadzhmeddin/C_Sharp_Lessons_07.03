// Напишите программу, которая на вход принимает число и выдаёт, является ли число четным (делится ли оно на два без остатка).


Console.Write("Введите число ");
int numberA = int.Parse(Console.ReadLine()!);


if (numberA % 2 == 0 )
{
    Console.WriteLine("Четное число");
}
else 
{
    Console.WriteLine("Нечётное число");
}
