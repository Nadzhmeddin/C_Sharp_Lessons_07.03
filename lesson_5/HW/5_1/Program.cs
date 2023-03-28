// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write("Кол-во элементов:");
int count =int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a =int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b =int.Parse(Console.ReadLine()!);

int[] MakeArray(int c, int m, int n){
    int[] array =new int[c];

    for (int i=0;i<array.Length;i++) array[i]=new Random().Next(m,n+1);
    return array;
}

void PrintArray(int[] arr){
    for (int i=0;i<arr.Length;i++) Console.Write($"{arr[i]} ");
}

int [] array = MakeArray(count, a, b);
PrintArray(array);

int CountNumbers(int[]arr)
{
    int count = 0;

    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count +=1;
    }
     return count;
}

CountNumbers(array);
Console.WriteLine();
Console.WriteLine(CountNumbers(array));
