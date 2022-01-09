//  7. Показать числа от -N до N
string numbers (int N)
{
    int count = 2*N+1;
    int index = 0;
    string row = String.Empty;
    while (index < count)
        {
        row = row + $" {-N+index}";
        index++;
    }
    return row;
}
int N = new Random().Next(5, 21);
string answer = numbers(N);
Console.WriteLine(answer);
