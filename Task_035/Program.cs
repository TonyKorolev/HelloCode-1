// 35. Определить, присутствует ли в заданном массиве, некоторое число 

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

void FindArray (int A, int[] array)
{
    int sum1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] == A)
        {
            Console.WriteLine($"Присутствует под номером {i}");
        }
        else
        {
            sum1 = sum1 + 1;
        }
    }
    if (sum1 == array.Length)
    {
        Console.WriteLine($"В данном массиве числа {A} нет");
    }
}

int [] array = new int [12];
CreatArray (array);
PrintArray (array);
Console.WriteLine("Введите число, которое нужно найти в массиве");
int A = Convert.ToInt32(Console.ReadLine());
FindArray (A, array);