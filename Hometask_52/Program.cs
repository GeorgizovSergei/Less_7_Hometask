// Задача 52.
// 1. Задайте двумерный массив из целых чисел.
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Задайте размер двумерного массива.\nУкажите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("]");
    }

}

void Arifmetic(int[,] matrix, int row)
{
    Console.WriteLine("Среднее арифметическое значение кажого столбца: ");
    Console.Write("[ ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double res = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res = (res + matrix[i, j]);
        }
        res = res / row;
        Console.Write(res + "\t");
    }
    Console.Write("]");
}


int[,] array2D = CreateMatrixRndInt(row, col);
PrintArray(array2D);
Arifmetic(array2D, row);