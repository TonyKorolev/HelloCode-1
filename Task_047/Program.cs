// 47. Написать программу копирования массива
// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

// Вывод массива
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Копирование массива
int [] CopyArray (int [] array)
{
    int [] array2 = new int [array.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        array2 [i] = array [i];
    }
    return array2;
}

int [] array = new int [8];
CreatArray(array);
PrintArray (array);
int [] array2 = CopyArray (array);
PrintArray (array2);


