// 68. Показать натуральные числа от M до N, N и M заданы
void PrintArray(int n, int m)
{
    Console.Write($"{m} ");
    if (m != n)
        PrintArray(n, m + 1);
}

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArray(N, M);


