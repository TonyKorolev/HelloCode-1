// 67. Показать натуральные числа от N до 1, N задано
void PrintNumbers (int n)
{
    Console.Write($"{n} ");
    if (n != 1) PrintNumbers(n-1);
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);
