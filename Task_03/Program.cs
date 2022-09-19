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
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colomns];
Random rnd = new Random();


if (rows * colomns <= 50)
{
    int value;
    bool Contains(int[,] arr, int value)
    {
        bool flag = false;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (value == arr[i, j])
                    flag = true;
            }
        }
        return flag;
    }

    void FillArray(int[,] array)
    {

        int tmp = rnd.Next(10, 100);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                value = rnd.Next(10, 100);
                while (Contains(array, value) == true)
                {
                    value = rnd.Next(10, 100);
                }
                array[i, j] = value;


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




