// 15. Дано число. Проверить кратно ли оно 7 и 23

int A = new Random().Next(7, 200);
Console.WriteLine(A);
if (A%7==0 && A%23==0)
{
    Console.WriteLine($"Число {A} кратно 7 и 23");
}
else if (A%7==0 && !(A%23==0))
{
    Console.WriteLine($"Число {A} кратно 7 и не кратно 23");
}
else if (!(A%7==0) && A%23==0)
{
    Console.WriteLine($"Число {A} не кратно 7 и кратно 23");
}
else
{
    Console.WriteLine($"Число {A} не кратно ни 7, ни 23");
}