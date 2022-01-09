// 6. Выяснить является ли число чётным

string parity(int a)
{
    string res = String.Empty;
    if (a%2==0)
    {
        res = "Число четное";
    }
    else
    {
        res = "Число нечетное";
    }
    return res;
}

int a = new Random().Next(1,100);
Console.WriteLine(a);
string answer = parity(a);
Console.WriteLine(answer);