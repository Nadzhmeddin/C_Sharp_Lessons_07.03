// Напишите программу, которая принимает на вход число и проверяет,кратно ли оно одновременно 7 и 23.

int num = new Random().Next (1, 1000);

void MyFunc(int num);
Console.WriteLine(num);
{
    if(num%7 == 0 && num%23 == 0)
    {
        Console.WriteLine("Кратно");
    }

    else
    {
        Console.WriteLine("Не кратно");
    }
}

MyFunc(num);
