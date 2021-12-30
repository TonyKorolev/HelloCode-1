int Day = new Random().Next(1, 8);
Console.WriteLine(Day);
if (Day == 6 || Day == 7)
{
    Console.WriteLine("День недели является выходным");
}
else
{
    Console.WriteLine("День недели не является выходным");
}