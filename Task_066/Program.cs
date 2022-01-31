// 66. Показать натуральные числа от 1 до N, N задано
void PrintNumbers (int n, int i = 1)
{
    Console.Write($"{i} ");
    if (i != n) PrintNumbers(n, i + 1);
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);
