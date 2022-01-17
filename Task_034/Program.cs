// 34. Написать программу замену элементов массива на противоположные
// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 50);
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

// Замена на противоположные элементы массивы
void ChangeArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]*(-1)} ");
    }
    Console.WriteLine();
}

int [] array = new int [12];
CreatArray (array);
PrintArray (array);
ChangeArray (array);