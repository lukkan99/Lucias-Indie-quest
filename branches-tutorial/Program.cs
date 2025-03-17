using System.ComponentModel.DataAnnotations.Schema;

int a = 5;
int b = 5;
int c = 4;
if( (a + b + c> 10) && (a == b))
{
    Console.WriteLine("The answer is grater then 10.");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not grater then 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

for (int counter = 0; counter <= 10; counter++)
{
    Console.WriteLine($"Hello World! The counter is  {counter}");
}

for (int row = 1; row < 11; row++)
{
    for(char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"the cell is ({row}, {column})");
    }
}