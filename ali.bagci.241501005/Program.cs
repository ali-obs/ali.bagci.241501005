Console.WriteLine(" Hello C# ");
Console.WriteLine();

Console.WriteLine("Name: Ahmet");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year: 2nd year");
Console.WriteLine();

Console.WriteLine($"Current Date and Time: {DateTime.Now}");
Console.WriteLine();

Console.Write("Enter temperature in °C:");

double celsius = double.Parse(Console.ReadLine()!);
double fahrenheit = (celsius * 9.0 / 5.0) + 32;

Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F ");


