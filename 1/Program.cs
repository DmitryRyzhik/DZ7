// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
double [,] GenereteMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rang = new Random();
    for(int i=0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {
            matrix[i,j] = Math.Round(rang.Next(-10,11)*0.1, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double [,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
    System.Console.WriteLine();     
    }
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m,n);
PrintMatrix(myMatrix);