//Напишите программу, которая принимает на вход трехзначное
// число и на выходе показывает последнюю цифру этого числа

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;  
}

// 123/10 -> 12 % 10 -> 2 (деление на 10 уменьшает на 1 цифру)
// 123 % 10 -> 3 (процент 10 забирает последнюю цифру)

int th_num = new Random().Next(100,1000);
 int result = TakeNum(th_num);

Console.WriteLine(result);
