﻿// 12. Удалить вторую цифру трёхзначного числа

int a = new Random().Next(100, 999);
Console.WriteLine(a);
int b = a/100;
int c = a%10;
int answer = b*10+c;
Console.Write($"После удаления второй цифры получаем {answer}");
