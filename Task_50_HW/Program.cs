// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElemByPos(int[,] array, int position)
// поиск производится по общепринятым положениям, что "17" - 1 строка 7 столбец,
{
    int a = position / 10 - 1;
    int b = position % 10 - 1;

    if (position < 11) Console.WriteLine("Введите число большее либо равное 11");

    else if 
    (array.GetLength(0) > a
    && array.GetLength(1) > b)
        Console.WriteLine(array[a, b]);

    else Console.WriteLine("Такого элемента в массиве нет");
}

int m = 3;
int n = 4;
int[,] arr = GetArray(m, n);
PrintArray(arr);

Console.WriteLine("Введите позицию искомого элемента");
int pos = int.Parse(Console.ReadLine());

FindElemByPos(arr, pos);

