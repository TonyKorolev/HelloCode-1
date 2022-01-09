int a = new Random().Next(10, 99);
int b = a/10;
int c = a%10;
int max = 0;
if (b==c)
{
    Console.WriteLine("Обе цифры равны");
}
else
{
    if (b>c) 
    {
        max = b;
    }
    else
    {
        max = c;
    }
    Console.Write($"Наибольшая цифра числа {a} равна {max}");
}
