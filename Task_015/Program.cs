int A = new Random().Next(100, 10000);
Console.WriteLine(A);
if (A%7==0)
{
    if (A%23==0)
    {
        Console.WriteLine($"Число {A} кратно 7 и 23");
    }
}
else
{
    Console.WriteLine($"Число {A} не кратно 7 и 23");
}