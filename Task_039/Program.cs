// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

// Вывод произведения пар
int [] FindAddArray (int[] array)
{
    int [] newArray = new int [array.Length/2];
    for (int i = 0; i < (array.Length/2); i++)
        {
            newArray [i] = array[i]*array[array.Length-i-1];
        }
    return newArray;
}

int [] array = new int [10];
CreatArray (array);
PrintArray (array);
int [] newArray = FindAddArray (array);
PrintArray (newArray);
