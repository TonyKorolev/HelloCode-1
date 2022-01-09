// 8. Показать четные числа от 1 до N
string numbers (int N)
{
    int index = 1;
    string row = String.Empty;
    while (index < N+1)
    {
        if(index%2==0)
        {
            row = row + $"{index} ";
        }
        index++;
    }
    return row;
}

int N = new Random().Next (1, 20);
string answer = numbers(N);
Console.WriteLine(answer);