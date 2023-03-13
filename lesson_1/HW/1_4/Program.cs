// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.


int numberA = int.Parse(Console.ReadLine()!);
int index = 2;

while (index <= numberA)
{
    Console.Write($"{index}");
    index += 2;
}
