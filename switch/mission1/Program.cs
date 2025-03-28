Console.Write("Set price: ");
string userOperations = "";
double totalprice;
string userinput = Console.ReadLine();
List<string> userinputarray = userinput.Split().ToList();
if((userinputarray.Count() > 3) ||((userinputarray.Count() > 1)&&(userinputarray.Count() < 3)))
{
    Console.WriteLine("invallid format");
}
else
{
    if(userinputarray.Count() == 3)
    {
        userOperations = userinputarray[1];
    }
    switch(userOperations)
    {
        case "+":
        case "plus":
        totalprice = double.Parse(userinputarray[0]) + double.Parse(userinputarray[2]);
        Console.WriteLine($"Total price : {totalprice}");
        break;

        case "-":
        case "minus":
        totalprice = int.Parse(userinputarray[0]) - int.Parse(userinputarray[2]);
        Console.WriteLine($"Total price : {totalprice}");
        break;

        case "/":
        case "divide":
        totalprice = int.Parse(userinputarray[0]) / int.Parse(userinputarray[2]);
        Console.WriteLine($"Total price : {totalprice}");
        break;

        case "*":
        case "multiply":
        totalprice = int.Parse(userinputarray[0]) * int.Parse(userinputarray[2]);
        Console.WriteLine($"Total price : {totalprice}");
        break;

        default:
        Console.WriteLine($"Total price : {userinputarray[0]}");
        break;
        

    }
}