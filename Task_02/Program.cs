// Задайте две квадратные матрицы одного размера.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] array = new int [2,2];
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

int [,] arrayNew = new int [2,2];
FillArray(arrayNew);
PrintArray(arrayNew);
Console.WriteLine(string.Empty);

int [,] resultArray = new int [2,2];


void MatrixMultiplication(int[,] array, int [,] arrayNew, int[,] resultArray)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            for (int k = 0; k < resultArray.GetLength(0); k++)
            {
                resultArray[i,j] += array[i,k] * arrayNew[k,j];
            }
        }
    }
}
MatrixMultiplication(array,arrayNew,resultArray);
PrintArray(resultArray);

