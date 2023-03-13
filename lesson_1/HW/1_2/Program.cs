// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих


int numberA = 0;
int numberB = 0;
int numberC = 0;


Console.Write("Введите первое число ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число ");
numberC = int.Parse(Console.ReadLine()!);

if (numberA > numberB )
{
   Console.WriteLine(numberA) ;
}
else
{
    Console.WriteLine(numberB) ;
}

if (numberA > numberC)
{
    Console.WriteLine(numberA) ;
}
else 
{
    Console.WriteLine(numberC) ;
}

if (numberB > numberC)
{
    Console.WriteLine(numberB) ;
}
else 
{
    Console.WriteLine(numberC) ;
}
