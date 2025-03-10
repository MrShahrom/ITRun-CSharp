using ITRunApp.Models;

// Console.Write("Enter your name: ");
// string urName = Console.ReadLine();
// Console.WriteLine($"Hello, {urName} ");

 /*   Console.Write("Input firstNumber: ");
    double num1 = double.Parse(Console.ReadLine());
    Console.Write("Input secondNumber: ");
    double num2 = double.Parse(Console.ReadLine());
    
    Console.Write("Input expression: ");
    double result = 0.0;
    char value = char.Parse(Console.ReadLine());
    
    double Sum(double num1, double num2)
    {
        return num1 + num2;
    }
    
    double Minus(double num1, double num2)
    {
        return num1 - num2;
    }
    
    double Devide(double num1, double num2)
    {
        return num1 / num2;
    }
    
    double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    
    switch (value)
    {
        case '+':
            result = Sum(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '-':
            result = Minus(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '*':
            result = Multiply(num1, num2);
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
        case '/':
            result = Devide(num1, num2);
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                break;
            }
            Console.WriteLine($"{num1} {value} {num2} = {result}");
            break;
    }*/
   

Calculator calculator = new Calculator();
while (true)
{
    Console.Write("Input first number: ");
    double num1 = double.Parse(Console.ReadLine());
        
    Console.Write("Input second number: ");
    double num2 = double.Parse(Console.ReadLine());
        
    Console.Write("Input operation (+, -, *, /): ");
    char operationChar = char.Parse(Console.ReadLine());

    if (!Enum.IsDefined(typeof(Operation), (int)operationChar))
    {
        Console.WriteLine("Invalid operation");
        return;
    }

    Operation operation = (Operation)operationChar;
    double result = 0.0;
        
    try
    {
        switch (operation)
        {
            case Operation.Add:
                result = calculator.Sum(num1, num2);
                break;
            case Operation.Subtract:
                result = calculator.Subtract(num1, num2);
                break;
            case Operation.Multiply:
                result = calculator.Multiply(num1, num2);
                break;
            case Operation.Divide:
                result = calculator.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }
        Console.WriteLine($"{num1} {operationChar} {num2} = {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

