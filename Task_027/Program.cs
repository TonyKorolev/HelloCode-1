// 27. Определить количество цифр в числе
int Numbers (int A)
{
    int count = 0;
    while (A != 0)
    {
        A = A/10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = Numbers (A);
Console.WriteLine($"В числе {A} {N} цифр");