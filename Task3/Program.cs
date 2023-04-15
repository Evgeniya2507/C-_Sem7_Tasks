// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = GetParameters("количество строк");
int n = GetParameters("количество столбцов");

int[,] Array = CreateArray(m, n);

PrintArray(Array);
AverageToСolumn(Array);


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

void AverageToСolumn(int[,] array)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        average = Math.Round(sum / array.GetLength(0), 1);
        System.Console.Write(average + "; ");
    }
}