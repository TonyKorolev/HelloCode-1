// 17. По двум заданным числам проверять является ли одно квадратом другого

string Find (int A, int B)
{
    string str = String.Empty;
    if (A*A==B)
    {
        str = ($"Число {B} является квадратом числа {A}");
    }
    else if (B*B==A)
    {
        str = ($"Число {A} является квадратом числа {B}");
    }
    else
    {
        str = ("Одно число не является квадратом другого");
    }
    return str;
}

int A = 36;
int B = 6;
string res = Find(A,B);
Console.WriteLine(res);