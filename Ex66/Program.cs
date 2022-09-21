Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int s =0;
if(M<N)
{
    for(int m=M; m<=N;m++)
    {

        Console.WriteLine(m);
    }
    for(int i=M;i<=N;i++)
    {
        s=s+i;
    }   
    Console.WriteLine(s);
}

else
{
    for(int n=N; n<=M;n++)
    {
        Console.WriteLine(n);
    }
    for(int i=N;i<=M;i++)
    {
        s=s+i;
    }   
    Console.WriteLine(s);
}
