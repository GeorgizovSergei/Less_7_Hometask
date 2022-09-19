// Задача 50.
// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки искомого элемента: ");
int rowFind = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int colFind = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 333);
        }

    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("]");
    }

}

void FindElemntMatrix(int[,] matrix, int rowFind, int colFind)
{
    if (rowFind > matrix.GetLength(0) || colFind > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве.");
    }
    else Console.WriteLine($"Значение элемента {rowFind} строки и {colFind} столбца равно {matrix[rowFind - 1, colFind - 1]}");


}

int[,] array2D = CreateMatrixRndInt(5, 5);
PrintArray(array2D);
FindElemntMatrix(array2D, rowFind, colFind);
