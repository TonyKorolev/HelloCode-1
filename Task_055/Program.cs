// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

// Вывод одномерного массива
void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Вычисление среднего арифметического каждого из столбцов
double [] AverageColumns (int [,] matrix)
{
    double [] NumberColumns = new double [matrix.GetLength(1)];
    double Average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Average = Average + matrix[i,j];
            
        }
        NumberColumns[j] = Average/matrix.GetLength(0);
        Average = 0;
    }
    return NumberColumns;
}

Console.WriteLine("Введите число строк двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, k];
CreatMatrix (matrix);
PrintMatrix (matrix);
double [] NumberColumnsArray = AverageColumns (matrix);
PrintArray (NumberColumnsArray);