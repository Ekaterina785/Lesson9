Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if(M<N)
{
    for(int m =M; m<=N;m++)
    Console.WriteLine(m);
}
else
{
    for(int n =N; n<=M;n++ )
    {
        Console.WriteLine(n);
    }
}