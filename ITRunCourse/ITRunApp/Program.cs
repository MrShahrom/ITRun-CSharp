// See https://aka.ms/new-console-template for more information

// Console.Write("Enter your name: ");
// string urName = Console.ReadLine();
// Console.WriteLine($"Hello, {urName} ");

Console.WriteLine("Input firstNumber:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input secondNumber");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Input expression:");
double result = 0.0;
char value = char.Parse(Console.ReadLine());

switch (value)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
}
Console.WriteLine($"{num1} {value} {num2} = {result}");