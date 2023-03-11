// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenereteMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rang = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rang.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PozitionMatrix(int i, int j, int m, int n, int[,] myMatrix)
{
    if ( i <= m && j <= n)
    {
        System.Console.WriteLine(myMatrix[i, j]);
    }
    else System.Console.Write("Элемента с таким индексом не существует");
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);
int i = ReadInt("Введите номер строки матрицы: ");
int j = ReadInt("Введите номер столбца матрицы: ");
PozitionMatrix(i, j, m, n, myMatrix);

