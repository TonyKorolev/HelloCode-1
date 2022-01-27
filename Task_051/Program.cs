// See https://aka.ms/new-console-template for more information

// Создание двумерного массива с заполнением суммой индексов
void CreatMatrix2Way (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число строк двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, k];
CreatMatrix2Way (matrix);
PrintMatrix (matrix);