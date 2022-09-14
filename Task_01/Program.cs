// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей
//суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] array = new int [3,5];
Random rnd = new Random();
void FillArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            array[i,j]= rnd.Next(0,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            Console.Write(" " + array[i,j]);
        }
        Console.WriteLine(string.Empty);
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine(string.Empty);

    int[] arrayAverageSum = new int [array.GetLength(0)];
    
    void SearchSumMinRows(int[,] array, int[] arrayAverageSum)
    {

        for(int i = 0; i< array.GetLength(0); i++)
        {
        int sumRows = 0;
        for(int j = 0; j< array.GetLength(1); j++)
        {
            sumRows = sumRows + array[i,j];
        }
        arrayAverageSum[i] = sumRows;
        Console.WriteLine(arrayAverageSum[i]);
        }
    }

SearchSumMinRows(array, arrayAverageSum);
Console.WriteLine(string.Empty);

int averageMinRows = arrayAverageSum[0];
    for(int i = 0;i<arrayAverageSum.Length;i++)
    {
    if(arrayAverageSum[i]<averageMinRows)
    {
        averageMinRows = arrayAverageSum[i];
    }
    }
Console.WriteLine(averageMinRows);