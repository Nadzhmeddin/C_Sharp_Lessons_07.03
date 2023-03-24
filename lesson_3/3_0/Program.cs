<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход координаты точки (Х и Y), причем Х не равно 0 или Y не равно 0 и 
// выдает номер четверти плоскости, в которой находится эта точка. 


void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
    Console.WriteLine("x =0, y=0");


else if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine(" 2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine(" 3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(" 4 четверть");
}
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1,num2);
=======
﻿
>>>>>>> 4_lesson
