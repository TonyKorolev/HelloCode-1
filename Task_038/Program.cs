// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
}

// Вывод массива
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Нахождение суммы чисел на нечетных позициях массива
int FindSum1Array (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array [i];
    }
    return sum;
}

int [] array = new int [10];
CreatArray (array);
PrintArray (array);
int sum = FindSum1Array (array);
Console.WriteLine($"Сумма нечетных элементов массива равна {sum}" );