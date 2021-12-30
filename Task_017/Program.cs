string Find (int A, int B)
{
    string str = String.Empty;
    if (A*A==B)
    {
        str = ($"Число {B} является квадратом числа {A}");
    }
    else
    {
        str = ("Одно число не является квадратом другого");
    }
    if (B*B==A)
    {
        str = ($"Число {A} является квадратом числа {B}");
    }
    else
    {
        str = ("Одно число не является квадратом другого");
    }
    return str;
}

int A = 5;
int B = 25;
string res = Find(A,B);
Console.WriteLine(res);