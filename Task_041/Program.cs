// 41. Выяснить являются ли три числа сторонами треугольника

void triangle(int A, int B, int C)
{
    if (((A + B) > C) && ((A + C) > B) && ((B + C) > A))
    {
        Console.WriteLine("Три числа являются сторонами треугольника");
    }
    else
    {
        Console.WriteLine("Три числа не являются сторонами треугольника");
    }
}

Console.WriteLine("Введите длину первой стороны треугольника");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину первой стороны треугольника");
int C = Convert.ToInt32(Console.ReadLine());
triangle(A, B, C);