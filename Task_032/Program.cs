// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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
CreatArray (array);
PrintArray (array);
