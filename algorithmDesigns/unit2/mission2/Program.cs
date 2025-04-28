static int Factorial(int n)
{
    if(n == 0)
    {
        return 1 ;
    
    }else
    {
        return (n * Factorial(n-1));
    }
}
for(int a = 0; a <=10; a++)
{
Console.WriteLine($"{a}!{Factorial(a)}");
}
