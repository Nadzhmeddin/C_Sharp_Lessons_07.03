// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend (int num)
{
    string text = " not quite a week";


    if (num == 7 || num == 6) text = " выходные";
    else if (num < 6 && num > 0) text = " Рабочие дни";

    Console.WriteLine ($"{num}    {text}");
}

int val = int.Parse(Console.ReadLine()!);
Weekend(val);
