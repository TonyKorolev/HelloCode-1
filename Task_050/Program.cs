// 50. В двумерном массиве n×k заменить четные элементы на противоположные

// Создание двумерного массива
void CreatMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
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

// Замена четных элементов на противоложные
void ChangeMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0)
                matrix[i, j] = - matrix[i, j];
        }
    }
}

Console.WriteLine("Введите число строк двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, k];
CreatMatrix (matrix);
PrintMatrix (matrix);
ChangeMatrix (matrix);
PrintMatrix (matrix);