// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задайте номер четверти");
int N = Convert.ToInt32(Console.ReadLine());
double PositiveInfinity = double.PositiveInfinity;
double NegativeInfinity = double.NegativeInfinity;
if (N == 1)
{
    Console.WriteLine($"Координаты x, y должны задаваться в промежутке (0, {PositiveInfinity}]");
}
else if (N == 2)
{
    Console.WriteLine($"Координата x должны задаваться в промежутке (0, {NegativeInfinity}], а y - (0, {PositiveInfinity}]");
}
else if (N == 3)
{
    Console.WriteLine($"Координаты x, y должны задаваться в промежутке (0, {NegativeInfinity}]");
}
else if (N == 4)
{
    Console.WriteLine($"Координата x должны задаваться в промежутке (0, {PositiveInfinity}], а y - (0, {NegativeInfinity}]");
}
else
{
    Console.WriteLine("ай-яй, ошибочка");
}