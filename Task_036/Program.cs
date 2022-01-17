// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int Find2Array (int[] array)
{
    int A = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) A++;
    }
    return A;
}

int [] array = new int [12];
CreatArray (array);
PrintArray (array);
int A = Find2Array (array);
int B = array.Length - A;
Console.WriteLine($"В массиве {A} четных чисел, {B} нечетных чисел");
