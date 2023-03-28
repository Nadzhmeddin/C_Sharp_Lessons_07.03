// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


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



int SumElements (int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i += 2)
        count += arr[i];

    return count;
}


PrintArray(array);
Console.WriteLine();
Console.WriteLine(SumElements(array));