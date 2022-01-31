// 54. В матрице чисел найти сумму элементов главной диагонали

// Создание двумерного массива
void CreatMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

// Вывод двумерного массива
void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", $"{matrix[i, j]} "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Сумма элементов главной диагонали
int SumDiagMatrix (int [,] matrix)
{
    int SumDiag = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) SumDiag = SumDiag + matrix[i,j];
        }
    }
    return SumDiag;
}

Console.WriteLine("Введите число строк и столбцов квадратного двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, n];
CreatMatrix (matrix);
PrintMatrix (matrix);
int SumDiag = SumDiagMatrix (matrix);
Console.WriteLine($"Сумма элементов главной диагонали равна {SumDiag}");