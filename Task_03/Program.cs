// Сформируйте двухмерный массив из неповторяющихся двузначных чисел
// (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

int [,] array = new int [5,5];
Random rnd = new Random();
void FillArray(int[,] array)
{
    
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            int tmp = rnd.Next(10,100);
            array[i,j] =rnd.Next(10,100);
            while(tmp == array[i,j])
            {
            array[i,j] = rnd.Next(10,100);
            }
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
        Console.WriteLine(" - Строка номер " + (i+1));
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine(string.Empty);





