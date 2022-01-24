// 45. Показать числа Фибоначчи
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите какое количество чисел Фибоначчи показать");
int Fibo = Convert.ToInt32(Console.ReadLine());
int [] FiboArray = new int [Fibo];
FiboArray[0] = 1;
FiboArray[1] = 1;
for (int i = 2; i < Fibo; i++)
{
    FiboArray [i] = FiboArray [i-1] + FiboArray [i-2];
}
PrintArray(FiboArray);