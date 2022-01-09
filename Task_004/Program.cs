// 4. Найти максимальное из трех чисел
int Max (int a, int b, int c)
{
    int max = a;
    if (b>max) max = b;
    if (c>max) max = c;    
    return max;
}

int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
Console.WriteLine($"{a}, {b}, {c}");
int n = Max(a, b, c);
Console.WriteLine($"Максимальное число {n}");