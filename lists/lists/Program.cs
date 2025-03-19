List<string> names = ["Lucia", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"The list has {names.Count} people in it");

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

List<int> fibonacciNummbers = [1,1];

var previous = fibonacciNummbers[fibonacciNummbers.Count -1];
var previous2 = fibonacciNummbers[fibonacciNummbers.Count -2];

fibonacciNummbers.Add(previous + previous2);

foreach(var item in fibonacciNummbers)
{
    Console.WriteLine(item);
}