// 10. Показать вторую цифру трёхзначного числа

int a = new Random().Next(100, 999);
Console.WriteLine(a);
int b = a/10;
int c = b%10;
Console.Write($"Вторая цифра трехзначного числа {a} есть {c}");
