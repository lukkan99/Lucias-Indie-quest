static string ordinalNumbers(int nummber)
{
    int lastDiget = nummber % 10;
    if(nummber > 10)
    {
        int secondLastDiget = nummber / 10 % 10;
        if(secondLastDiget == 1)
        {
            return ($"{nummber}th");
        }
        else
        {
            switch(lastDiget)
            {
                default:
                return($"{nummber}th");
                case 1:
                return($"{nummber}st");
                case 2:
                return($"{nummber}nd");
                case 3:
                return($"{nummber}rd");
            }
            

        }
    }
    switch(lastDiget)
            {
                default:
                return($"{nummber}th");
                case 1:
                return($"{nummber}st");
                case 2:
                return($"{nummber}nd");
                case 3:
                return($"{nummber}rd");
            }

}

Console.WriteLine(ordinalNumbers(1));
Console.WriteLine(ordinalNumbers(2));
Console.WriteLine(ordinalNumbers(3));
Console.WriteLine(ordinalNumbers(4));
Console.WriteLine(ordinalNumbers(10));
Console.WriteLine(ordinalNumbers(11));
Console.WriteLine(ordinalNumbers(12));
Console.WriteLine(ordinalNumbers(13));
Console.WriteLine(ordinalNumbers(21));
Console.WriteLine(ordinalNumbers(101));
Console.WriteLine(ordinalNumbers(111));
Console.WriteLine(ordinalNumbers(121));
