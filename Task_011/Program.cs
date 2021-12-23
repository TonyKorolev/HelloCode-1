int a = new Random().Next(10, 99);
Console.WriteLine(a);
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
    Console.Write("Наибольшая цифра числа ");
    Console.Write(a);
    Console.Write(" равна ");
    Console.Write(max);
}
