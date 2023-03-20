// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

string SecondNum(int num)
{
    if (num < 1000 && num > 99);
        return $"{num / 100*10 + num % 10}";
    return "Данное число не трёхзначное";
}

int res = int.Parse(Console.ReadLine()!);
string result = SecondNum(res);
Console.WriteLine(result);