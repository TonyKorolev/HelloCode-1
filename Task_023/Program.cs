// 23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N+1; i++)
{
    int square = i*i;
    Console.WriteLine($"{i} * {i} = {square}");
}
