// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.

int GetNum();
{
    int number = new Random().New(10, 100);
    return number;
}
int Second (int n)
{
    return n%10;
}

