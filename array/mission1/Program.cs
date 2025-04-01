

static string CreateDayDescription(int day, int season, int year)
{
string[] Seasons = ["Spring","Summer","Fall","Winter"];
string theDay;
string finalOutput;
var digit = Convert.ToString(day);
int lastDit = int.Parse(digit.Substring(digit.Length - 1));
switch(lastDit)
{
    case 1:
    theDay = ($"{day}st");
    break;
    
    case 2:
    theDay = ($"{day}nd");
    break;

    default:
    theDay = ($"{day}th");
    break;
}
finalOutput = ($"{theDay} day of {Seasons[season]} in the {year}");
return finalOutput;
}

Console.WriteLine(CreateDayDescription(21, 3,1996));
Console.WriteLine(CreateDayDescription(2, 1,1996));
Console.WriteLine(CreateDayDescription(3, 2,1997));
Console.WriteLine(CreateDayDescription(4, 0,1997));