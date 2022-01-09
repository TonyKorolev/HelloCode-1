// 9. Показать последнюю цифру трёхзначного числа
int a = new Random().Next(100, 999);
Console.WriteLine(a);
int b = a%10;
Console.Write($"Последняя цифра числа {a} есть {b}");
