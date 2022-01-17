// 29. Написать программу вычисления произведения чисел от 1 до N
int Add (int N)
{
    int adding = 1;
    for (int i = 1; i <= N; i++)
    {
        adding = adding * i;
    }
    return adding;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int answer = Add(N);
Console.WriteLine($"Произведение чисел от 1 до {N} равна {answer}");