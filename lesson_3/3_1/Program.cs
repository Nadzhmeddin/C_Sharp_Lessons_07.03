// Напишите программу, которая принимает на вход координаты точки (X , Y), причём Х не равно 0
// или Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(int x, int y)
{
    if ( x == 0 || y == 0)
    Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
    Console.WriteLine("Первая четверть");
    else if ( x < 0 && y > 0)
    Console.WriteLine("Вторая четверть");
     else if ( x < 0 && y < 0)
    Console.WriteLine("Третья четверть");
     else if ( x > 0 && y < 0)
    Console.WriteLine("Четвертая четверть");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1 , num_2);