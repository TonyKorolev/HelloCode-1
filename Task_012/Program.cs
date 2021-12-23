int a = new Random().Next(100, 999);
Console.WriteLine(a);
int b = a/100;
int c = a%10;
Console.Write("После удаления второй цифры получаем ");
Console.Write(b);
Console.Write(c);