// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет

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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Вывод позиций чисел
void PrintPositions (int [,] matrix, int N)
{
    int AmountElements = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == N)
            {
                Console.WriteLine($"{i}, {j}");
            }
            else
            {
                AmountElements++;
            }
        }
    }
    if (AmountElements == matrix.Length)
        Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите число строк двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, k];
CreatMatrix (matrix);
PrintMatrix (matrix);
Console.WriteLine("Введите число, я выведу его позиции");
int N = Convert.ToInt32(Console.ReadLine());
PrintPositions (matrix, N);