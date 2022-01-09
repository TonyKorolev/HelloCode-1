// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток

int a = new Random().Next(1, 999);
Console.WriteLine(a);
Console.WriteLine("Введите число, на которое нужно разделить");
int b = Convert.ToInt32(Console.ReadLine());
if (a%b==0)
{
    Console.WriteLine("Кратно");
}
else
{
    int c = a%b;
    Console.Write("Остаток равен ");
    Console.Write(c);
}