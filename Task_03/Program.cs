// Сформируйте двухмерный массив из неповторяющихся двузначных чисел
// (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, column];
if(array.GetLength(0)*array.GetLength(1)<=50)
{
Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rnd.Next(10, 100);
            for (int m = 0; m < array.GetLength(0); m++)
            {
                for (int n = 0; n < array.GetLength(1); n++)
                {

                    if (array[i, j] == array[m, n])
                    {
                        array[m, n] = rnd.Next(10, 100);
                    }
                }
            }
        }
    }
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine(" - Строка номер " + (i + 1));
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine(string.Empty);
}
else
{
    Console.WriteLine("Введите массив, менее 50 значений");
}




