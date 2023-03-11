// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void Sum(int m, int n, int[,] myMatrix)
{
    double[] sum = new double[m];
    for ( int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] += myMatrix[j, i];
        }
        // System.Console.Write(sum[i] / m + " ");
    }
    
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
Sum(m, n, myMatrix);