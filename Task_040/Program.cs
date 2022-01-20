// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// Создание массива
void CreatPrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10+10;
        array[i] = Math.Round(array[i], 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Вывод разницы максимального и минимального элементов
double FindDifArray (double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    double dif = max - min;
    return dif;
}

double [] array = new double [10];
CreatPrintArray (array);
double dif = FindDifArray (array);
Console.WriteLine($"Разница между максимальным и минимальным элементами равен {dif}");