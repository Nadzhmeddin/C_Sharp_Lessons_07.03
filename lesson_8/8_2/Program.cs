// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int arrRows = 3;
int arrColumns = 3; 
int arrMin = 1; 
int arrMax = 9;

int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
int[]freq = CountFrequency(arr, arrMax);
PrintFriquencies(freq);

int[] CountFrequency(int[,] array, int max)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int[] frequencies = new int[max + 1];

    foreach(int elem in array )
    {
        frequencies[elem] ++;
    }
    return frequencies;  
}

void PrintFriquencies(int[]array)
{
    for(int i =0; i < array.Length;i++)
    {
        Console.WriteLine($"Количество {i}-> {array[i]} ");
    }
    Console.WriteLine();
}


int[,] Make2DArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    for(int i = 0; i< rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
        arr[i, j] = new Random().Next(min, max + 1);   
        }
    }return arr;
}

void Print2DArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j]} ");
            Console.WriteLine();         
    }
}