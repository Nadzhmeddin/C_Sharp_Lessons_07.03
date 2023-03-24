// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}


bool FindNumber (int[] arr, int n)
{
    for (int i = 0; i < arr.length; i++)
    {
        if (arra[i] == n)
        {
            return true;
        }
}
return false;

}
Console.Write("Введите число:");
int n= int.Parse(Console.ReadLine()!);

Console.WriteLine(FindNumber(array,n));