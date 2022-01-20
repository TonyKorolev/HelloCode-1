// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Создание массива
void CreatArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 500);
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

// Нахождение в массиве чисел от A до B
int FindABArray (int[] array, int A, int B)
{
    int N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array [i] >= A) && (array [i] <= B)) N++;
    }
    return N;
}

int [] array = new int [123];
CreatArray (array);
PrintArray (array);
Console.WriteLine("Введите начало отрезка");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отрезка");
int B = Convert.ToInt32(Console.ReadLine());
int N = FindABArray (array, A, B);
Console.WriteLine($"В массиве в промежутке от [{A}, {B}] {N} элементов");