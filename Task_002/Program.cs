// Даны два числа. Показать большее и меньшее число
int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
Console.WriteLine($"Даны числа {a}, {b}");
if (a > b)
{
Console.Write($"Большее {a}, меньшее {b}");
}
else 
{
Console.Write($"Большее {b}, меньшее {a}");
}