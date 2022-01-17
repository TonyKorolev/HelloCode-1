// 31. Задать массив из 8 элементов и вывести их на экран
void CreatArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int [] array = new int [8];
CreatArray(array);
PrintArray (array);
