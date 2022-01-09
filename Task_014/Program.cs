// 14. Найти третью цифру числа или сообщить, что её нет

int Find (int N)
{
    string str = N.ToString();
    int[] b = new int[str.Length];
    for( int i = 0; i < str.Length; i++)
    {
        b[i] = int.Parse(str[i].ToString());
    }
    return b[2];
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100) 
{
    int s = Find(a);
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
