int FindThirdDigit(int N);
{
    string str = N.ToString();
    int[] b = new int[str.Length];
    for( int i=0; i< str.Length; i++)
    {
        b[i] = int.Parse(str[i].ToString());
    }
    Console.WriteLine("Третья цифра равна ");
    return b[2];
}
int A = new Random().Next(1, 10000);
Console.WriteLine(A);
int s = FindThirdDigit(A);