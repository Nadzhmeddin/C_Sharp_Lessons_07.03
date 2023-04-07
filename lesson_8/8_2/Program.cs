// Составить частотый словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько  раз встречается элемент входных данных.

int arrRows = 3;
int arrColumns = 3;
int arrMin = 1;
int arrMax = 9;

int [,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
ChangeRowsOnColumns(arr);
Print2DArray(arr);

void CountFrequency(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    if(rows == columns)
    {
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
        }
    }
}