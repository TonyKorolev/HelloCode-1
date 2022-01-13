// 28. Подсчитать сумму цифр в числе
int SumNumbers (int A)
{
    int sum = 0;
    while (A > 0)
    {
        int B = A % 10;
        A = A/10;
        sum = sum + B;
    }
    return sum;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = SumNumbers (A);
Console.WriteLine($"В числе {A} сумма цифр равна {N}");
