// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число больше, а какое меньшее

int numberA = 0;
int numberB = 0;


Console.Write("Введите первое число ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine("Первое число больше второго");
}
else if ( numberA == numberB)
{
    Console.WriteLine("Оба числа равны");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}
