// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = GetParameters("количество строк");
int n = GetParameters("количество столбцов");
int x = GetParameters("искомое значение массива");

int[,] Array = CreateArray(m, n);

PrintArray(Array);
ShowResultSearchOfElement(Array, x);

void ShowResultSearchOfElement(int[,] array, int x)
{
    if (CheckOfElement(array, x))
    {
        System.Console.WriteLine($"Число {x} присутствует в заданном массиве");
    }
    else
    {
        System.Console.WriteLine($"Число {x} отсутствует в заданном массиве");
    }
}

int GetParameters(string argument)
{
    System.Console.Write($"Введите {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int length1, int length2)
{
    int[,] array = new int[length1, length2] ;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

bool CheckOfElement(int[,] array, int x)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x) return true;
        }   
    }
    return false;
}